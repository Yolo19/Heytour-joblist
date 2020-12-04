import React, { useState}from 'react'
import { Grid, Image,Card, Icon,Item, List, Divider  } from 'semantic-ui-react'
import joblist from './JobListData'

  
export default function GridExampleCelled (props) {


return (  
<>
    {
    joblist.map((item,index)=>(
        <Grid celled>  
        <Grid.Row>
            <Grid.Column width={3}>
            <Card>
                <Image key={index} src={item.picture} wrapped ui={false} />
                <Card.Content>
                    <Card.Header id='title'>{item.company}</Card.Header>
                </Card.Content>
                <Card.Content extra>
                    <Icon name='map marker alternate' />{item.location}
                </Card.Content>
            </Card>
            </Grid.Column>
            <Grid.Column width={13}>
            <List>
                <List.Item>
                    <List.Content>
                        <List.Header as='a'>{item.title}</List.Header>
                    </List.Content>
                </List.Item>
                <List.Item>
                    <List.Content>
                        <List.Description>{item.company}</List.Description>
                        <List.Description>{item.industry}</List.Description>
                        <List.Description>{item.jobDesc}</List.Description>
                        <List.Description>{item.email}</List.Description>
                        <List.Description>{item.postedOn}</List.Description>
                    </List.Content>
                </List.Item>
            </List>
            </Grid.Column>
        </Grid.Row>
        </Grid>
    ))
    }
</>
)
}