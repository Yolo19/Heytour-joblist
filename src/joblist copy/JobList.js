import React, { useState}from 'react'
import { Grid, Image,Card, Icon,Item, List, Divider, Container, Button, Label  } from 'semantic-ui-react'
import joblistData from './JobListData'

export default function JobList(props) {

    return (
        <>
        {
            joblistData.map((item,index)=>(
                <List size='big' relaxed='very'>
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
                    <Button color='green'>
                    <Icon name='heart' /> Like
                    </Button>
                    <Button color='orange'>
                        <Icon name="paper plane" />Apply 
                    </Button>
                </List> 
            ))
        }
        </>
    )
}