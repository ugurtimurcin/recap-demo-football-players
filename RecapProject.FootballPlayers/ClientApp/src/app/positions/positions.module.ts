import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PositionsRoutingModule } from './positions-routing.module';
import { ListComponent } from './list/list.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [ListComponent, CreateComponent, EditComponent],
  imports: [
    CommonModule,
    PositionsRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class PositionsModule { }
