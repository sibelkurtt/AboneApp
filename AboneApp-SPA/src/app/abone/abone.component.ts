import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-abone',
  templateUrl: './abone.component.html',
  styleUrls: ['./abone.component.css']
})
export class AboneComponent implements OnInit {
  abones: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAbones();
  }

  getAbones(){
    this.http.get('http://localhost:5000/api/abones').subscribe(
      response => {
          this.abones = response;
      },
      error => {
          console.log(error);
      }
    );
  }

}
