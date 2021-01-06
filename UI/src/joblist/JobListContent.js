import React from 'react'
import { Card, Icon, Image, Button, Divider } from 'semantic-ui-react'
import moment from 'moment'
import JobForm from '../createJobs/JobForm';

export default function JobListContent(props) {

  return (
    <Card style={{margin:'10px'}}>
      <Card.Content>
        <Image
          size='tiny'
          src={props.job.picture}
        />
        <Card.Meta>{props.job.company}</Card.Meta>
        <Card.Header>{props.job.title}</Card.Header>
        <Card.Meta>{props.job.industry}</Card.Meta>
        <Divider />
        <Card.Description><strong>{props.job.jobDesc}</strong></Card.Description>
        <Divider hidden />

        
          <Card.Meta textAlign='left'> <Icon name='map marker alternate' />{props.job.location}</Card.Meta>
          <Divider hidden />
          <Card.Description textAlign='left'>{'Listed On: ' + moment(props.job.postedOn).format('DD MMM YYYY')}</Card.Description>
      </Card.Content>
      <Card.Content extra>
        <div className='ui two buttons'>
          <Button basic color='red'>
              <Icon name='delete'/> Delete
          </Button>
          <Button basic color='green'>
            <Icon name='edit'/> Edit
          </Button>
        </div>
      </Card.Content>
    </Card>
  )

}