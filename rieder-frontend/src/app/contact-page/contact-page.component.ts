import { Component, OnInit } from '@angular/core';

import {FormGroup, FormBuilder, Validators} from '@angular/forms'

@Component({
  selector: 'app-contact-page',
  templateUrl: './contact-page.component.html',
  styleUrls: ['./contact-page.component.css']
})
export class ContactPageComponent implements OnInit {

  contactForm : FormGroup ;

  constructor( private fb: FormBuilder) {

    this.contactForm = this.fb.group({
      firstname: [''],
      lastname: [''],
      email: [''],
      message: ['']
     

    })

   }


  ngOnInit(): void {
    this.contactForm
  }

  onSubmit(){
    console.log(this.contactForm.value)
  }

}
