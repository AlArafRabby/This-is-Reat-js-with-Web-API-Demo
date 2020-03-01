import React, { Component } from 'react';
import '../../node_modules/bootstrap/dist/css/bootstrap.min.css'

class Welcome extends Component
{
    constructor(){
        super()

        this.state={
            name:"joy",
            age:"22"
        }

    }

    render()
    {
    return <h1>{this.state.name} and {this.state.age}</h1>
    }
}
/*const ClickFunc=(a)=>{
    alert(a)
}


const MyFun=()=>
{
    return(
        <button onClick={ClickFunc.bind(this,"this is arrow function")} className="btn btn-danger m-5">Arrow Function Clicked</button>
    );
}
*/

export default Welcome;