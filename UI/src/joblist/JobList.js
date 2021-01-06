import React from 'react'
import { Container, Grid, Icon, Segment, Button, Modal,Form  } from 'semantic-ui-react'
import { useJobList } from './JobListAPI'
import JobListContent from './JobListContent';
import JobForm from '../createJobs/JobForm';
import { useReducer } from 'react';
import { useState} from 'react';

let style = {
  grid : {margin:"30px"},
}


export default function JobList() {
  const [jobList, setJobListFilter] = useJobList(null);
  const [open, setOpen] = React.useState(false)

  return (
    <Container fluid textAlign='center'>
      <JobForm />
      <Grid style={style.grid}>
      {jobList.data && jobList.data.map((job) => (
          <JobListContent
            key={job.id}
            isLoading={jobList.isLoading}
            job={job}
          />
        ))}
      
      </Grid>
    </Container>   
  )

}