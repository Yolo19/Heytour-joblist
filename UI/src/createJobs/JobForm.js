import React from 'react'
import { Button, Checkbox, Form, Icon, Modal } from 'semantic-ui-react'

export default function JobForm(props){
    const [open, setOpen] = React.useState(false)
    return (
        <Modal
        onClose={() => setOpen(false)}
        onOpen={() => setOpen(true)}
        open={open}
        trigger={<Button><Icon name='plus'/>Create new Job</Button>}
        >
            <Modal.Header>Create New Job</Modal.Header>
            <Modal.Content>
            <Form>
                <Form.Input required name='Job Title' label='Job Title' placeholder='Job Title'/> 
                <Form.Input required name='Location' label='Location' placeholder='Location' />
                <Form.Input required name='Industry' label='Industry' placeholder='Industry' />
                <Form.Input required name='Picture' label='Picture' placeholder='Picture' />
                <Form.Input required name='Company' label='Company' placeholder='Company' />
                <Form.Input required name='Email' label='Email' placeholder='Email' />
                <Form.Input required name='Job Description' label='Job Description' placeholder='Job Description' />
                <Button onClick={() => setOpen(false)}>Cancel</Button>
                <Button type='submit'>Submit</Button>
            </Form>
            </Modal.Content>
        </Modal>
    )
}