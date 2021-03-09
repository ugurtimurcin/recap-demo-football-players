import { Component, OnInit } from '@angular/core';
import { from } from 'rxjs';
import { Position } from '../position'
import { PositionsService } from '../positions.service'
@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  positions: Position[] = [];

  constructor(public positionService: PositionsService) { }

  ngOnInit() {
    this.positionService.getPositions().subscribe((data: Position[]) => {
      this.positions = data;
    })
  }
}
