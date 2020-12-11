import React, { useState}from 'react'
import { Grid, Image,Card, Icon,Item, List, Divider, Container, Button, Label  } from 'semantic-ui-react'
import JobCard from './JobCard'
import JobList from './JobList'
import joblistData from './JobListData'
  
export default function JobListContent(props) {

    return (
      <Card.Group itemsPerRow={2}>
        <Card>
          <Image src={props.job.picture} wrapped ui={false} />
  
          <Card.Content>
            <Card.Header>{props.job.company}</Card.Header>
            <Card.Meta>{props.job.location}</Card.Meta>
            <Card.Description>{props.job.postedOn}</Card.Description>
          </Card.Content>
  
          <Card.Content extra>
            <a>
              <Icon name='star' />
              10 Applied
            </a>
          </Card.Content>
        </Card>
  
        <Card>
  
          <Card.Content>
            <Card.Header>{props.job.title}</Card.Header>
            <Card.Meta>{props.job.industry}</Card.Meta>
            <Card.Description>{props.job.jobDesc}</Card.Description>
          </Card.Content>
  
          <Card.Content extra>
            <div className='ui two buttons'>
            <Button color='google plus'>
              <Icon name='heart' /> Save
            </Button>
            <Button color='instagram'>
              <Icon name='plus' /> Apply
            </Button>
            </div>
          </Card.Content>
        </Card>
      </Card.Group>
    )
  
  }