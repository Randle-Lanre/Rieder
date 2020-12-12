import { Component, OnInit } from '@angular/core';
// import { from } from 'rxjs';
import { FormGroup, FormBuilder, Validators} from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  
   loginForm: FormGroup ;

  

  constructor(private fb: FormBuilder ) {
    this.loginForm = this.fb.group({
      username: [''],
      password: ['']
    })
  
    
   }
  
  

  ngOnInit(): void {
    
this.loginForm
    
  }


  //click submission even 

  onSubmit(){
    console.log(this.loginForm.value);
  }
 }
