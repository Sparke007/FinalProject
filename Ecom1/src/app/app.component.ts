import { Component, OnInit } from '@angular/core';
import { MessageService } from 'primeng/api';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent  implements OnInit {
  title = 'Ecom';

  uploadedFiles: any[] = [];
  constructor
  (
    private messageService:MessageService,



    ){}

ngOnInit()
{


}
onUpload(event:any){

for(let file of event.files) {
            this.uploadedFiles.push(file);
        }

        this.messageService.add({severity: 'info', summary: 'File Uploaded', detail: ''});
    }

}







