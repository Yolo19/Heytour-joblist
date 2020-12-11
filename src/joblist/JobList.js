import React from 'react'
import { Card,Container, Grid } from 'semantic-ui-react'
import { useJobList } from './JobListAPI'
import JobListContent from './JobListContent';

let style = {
  grid : {margin:"30px"},
}
export default function JobList() {
  const [jobList, setJobListFilter] = useJobList(null);

  return (
    <Container fluid textAlign='center'>
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