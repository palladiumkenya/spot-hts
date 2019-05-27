import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StatsComponent } from './stats/stats.component';
import {HttpClientModule} from '@angular/common/http';
import {
    AccordionModule, AutoCompleteModule,
    BreadcrumbModule,
    ButtonModule, CalendarModule,
    CardModule, CarouselModule,
    ChartModule, CheckboxModule,
    ChipsModule, CodeHighlighterModule, ColorPickerModule,
    ConfirmDialogModule, ContextMenuModule, DialogModule,
    DropdownModule, EditorModule, FieldsetModule, FileUploadModule,
    GalleriaModule,
    GrowlModule,
    InplaceModule, InputMaskModule,
    InputSwitchModule,
    InputTextareaModule, InputTextModule, LightboxModule,
    ListboxModule,
    MegaMenuModule, MenubarModule,
    MenuModule, MessageModule,
    MessagesModule,
    MultiSelectModule, OrderListModule, OrganizationChartModule, OverlayPanelModule,
    PaginatorModule,
    PanelMenuModule,
    PanelModule,
    PasswordModule,
    PickListModule, ProgressBarModule,
    RadioButtonModule, RatingModule,
    ScrollPanelModule,
    SelectButtonModule, SlideMenuModule,
    SliderModule, SpinnerModule, SplitButtonModule, StepsModule,
    TabMenuModule, TabViewModule,
    TerminalModule, TieredMenuModule, ToggleButtonModule, ToolbarModule, TooltipModule,
    TreeModule,
    TreeTableModule
} from 'primeng/primeng';
import {FullCalendarModule} from 'primeng/fullcalendar';
import {FormsModule} from '@angular/forms';
import {ToastModule} from 'primeng/toast';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {TableModule} from 'primeng/table';
import {DataViewModule} from 'primeng/dataview';
import {VirtualScrollerModule} from 'primeng/virtualscroller';

@NgModule({
  declarations: [
    AppComponent,
    StatsComponent
  ],
  imports: [
      BrowserModule,
      FormsModule,
      HttpClientModule,
      BrowserAnimationsModule,
      AccordionModule,
      AutoCompleteModule,
      BreadcrumbModule,
      ButtonModule,
      CalendarModule,
      CardModule,
      CarouselModule,
      ChartModule,
      CheckboxModule,
      ChipsModule,
      CodeHighlighterModule,
      ConfirmDialogModule,
      ColorPickerModule,
      ContextMenuModule,
      DataViewModule,
      DialogModule,
      DropdownModule,
      EditorModule,
      FieldsetModule,
      FileUploadModule,
      FullCalendarModule,
      GalleriaModule,
      GrowlModule,
      InplaceModule,
      InputMaskModule,
      InputSwitchModule,
      InputTextModule,
      InputTextareaModule,
      LightboxModule,
      ListboxModule,
      MegaMenuModule,
      MenuModule,
      MenubarModule,
      MessageModule,
      MessagesModule,
      MultiSelectModule,
      OrderListModule,
      OrganizationChartModule,
      OverlayPanelModule,
      PaginatorModule,
      PanelModule,
      PanelMenuModule,
      PasswordModule,
      PickListModule,
      ProgressBarModule,
      RadioButtonModule,
      RatingModule,
      ScrollPanelModule,
      SelectButtonModule,
      SlideMenuModule,
      SliderModule,
      SpinnerModule,
      SplitButtonModule,
      StepsModule,
      TableModule,
      TabMenuModule,
      TabViewModule,
      TerminalModule,
      TieredMenuModule,
      ToastModule,
      ToggleButtonModule,
      ToolbarModule,
      TooltipModule,
      TreeModule,
      TreeTableModule,
      VirtualScrollerModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
