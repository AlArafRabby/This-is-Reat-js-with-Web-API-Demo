import React from 'react'

function First(props)
{

function DoThis(a)
{
    alert(a)
}



return (

    <div>
        <button onClick={DoThis.bind(this,"this is test")}>Click Me</button>
        <h1>this is {props.name} first function</h1>
    </div>
    
)


}


export default First