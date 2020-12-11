import React, { useState}from 'react'
import { Grid, Image,Card, Icon,Item, List, Divider, Container, Button, Label  } from 'semantic-ui-react'
import joblistData from './JobListData'

export default function JobCard(props) {
    return (
        <>
                <Card>
                    <Image src={props.joblistData.picture} wrapped ui={false} />
                <Card.Content>
                    <Card.Header id='title'>{props.job.company}</Card.Header>
                </Card.Content>
                <Card.Content extra>
                    <Icon name='map marker alternate' />{props.job.location}
                </Card.Content>
                </Card>
            )
        </>
        
    )
        
    
}