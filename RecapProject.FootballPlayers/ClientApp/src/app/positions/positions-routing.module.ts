import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { CreateComponent } from './create/create.component';
import { EditComponent } from './edit/edit.component';


const routes: Routes = [
  { path: 'positions', redirectTo: 'positions/index', pathMatch: 'full' },
  { path: 'positions/list', component: ListComponent },
  { path: 'positions/create', component: CreateComponent },
  { path: 'positions/:playerId/edit', component: EditComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PositionsRoutingModule { }
