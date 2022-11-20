import { Component, OnInit } from '@angular/core';
import { QUESTIONS } from './questions/mock-questions';
import { Question } from './questions/question';

@Component({
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: ['./forms.component.css']
})
export class FormsComponent implements OnInit{

  Questions = QUESTIONS;

  selectedQuestion: Question = this.Questions[0];

  constructor() { }

  ngOnInit(): void {
  }

  onSelect(question: Question): void {
    this.selectedQuestion = question;
  }
}
