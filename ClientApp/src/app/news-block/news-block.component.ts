import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-news-block',
  templateUrl: './news-block.component.html',
  styleUrls: ['./news-block.component.css']
})
export class NewsBlockComponent implements OnInit {

  public news: [];
  // public article = {
  //   title: 'Test Title',
  //   description: 'this is a test desctription'
  // };

  constructor(private http: HttpClient) {
    http.get<NewsResponse>('https://newsapi.org/v2/top-headlines?country=us&apiKey=fb91f9ff2ed847fb900d0510d46440e6').subscribe(res => {
      this.news = res.articles;
      console.log(this.news);
    });
  }

  ngOnInit() {
  }
}

interface NewsResponse {
  status: string;
  articles: [];
}
