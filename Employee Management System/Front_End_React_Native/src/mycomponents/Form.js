import React, { Component } from 'react';

class Form extends Component {
constructor()
{
    super();
    this.state={
        fname:" ",
        lname:" ",
        email:" ",
        mobile:" ",
        age:" "
    }
}



 onChangeHandler=(event)=>{
          var inputname=event.target.name;
          var inputvalue=event.target.value;
          this.setState({[inputname]:inputvalue});
          if(inputname==="fname")
          {
            var namePattern=/^([a-zA-Z]){2,30}$/;
            if(!namePattern.test(inputvalue))
            {
                this.setState({fname:"First name is not valid"});
            }
          }
          if(inputname==="lname")
          {
            var namePattern2=/^([a-zA-Z]){2,30}$/;
            if(!namePattern2.test(inputvalue))
            {
                this.setState({lname:"Last name is not valid"});
            }
          }
          if(inputname==="email")
          {
            var namePattern3=/[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+/;
            if(!namePattern3.test(inputvalue))
            {
                this.setState({email:"Email is not valid"});
            }
          }
          if(inputname==="mobile")
          {
            if(!Number(inputvalue))
            {
                this.setState({mobile:"Mobile is not valid"});
            }
          }
          if(inputname==="age")
          {
            if(!Number(inputvalue))
            {
                this.setState({age:"Age is not valid"});
            }
          }
          
    }

    
    render() {
        return (
            <div className="form-group">
                <form>
                    <p>My New Form</p>
                    <p> First Name :{this.state.fname}</p>
                    <p> Last Name :{this.state.lname}</p>
                    <p> Email :{this.state.email}</p>
                    <p> Mobile :{this.state.mobile}</p>
                    <p> Age :{this.state.age}</p>
                    <input  name="fname" onChange={this.onChangeHandler} type="text" placeholder="Your first name"></input><br></br>
                    <input name="lname" onChange={this.onChangeHandler} type="text" placeholder="Your last name"></input><br></br>
                    <input name="email" onChange={this.onChangeHandler} type="text" placeholder="Your email"></input><br></br>
                    <input name="mobile" onChange={this.onChangeHandler} type="text" placeholder="Your mobile"></input><br></br>
                    <input name="age" onChange={this.onChangeHandler} type="text" placeholder="Your age"></input><br></br>
                    <input type="submit" value="Submit Now" ></input>
                </form>
            </div>
        );
    }
}

export default Form;