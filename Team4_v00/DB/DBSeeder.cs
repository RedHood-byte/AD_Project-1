﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Ben_Project.Models;
using Ben_Project.Utils;

namespace Ben_Project.DB
{
    public class DBSeeder
    {
        public DBSeeder(LogicContext dbContext)
        {
            // Adding Stationery Data

            Stationery s1 = new Stationery();
            s1.ItemNumber = "C001";
            s1.Category = Category.Clip;
            s1.Description = "Clips Double 1";
            s1.Uom = UOM.Dozen;

            Stationery s2 = new Stationery();
            s2.ItemNumber = "C004";
            s2.Category = Category.Clip;
            s2.Description = "Clips Paper Large";
            
            s2.Uom = UOM.Box;

            Stationery s3 = new Stationery();
            s3.ItemNumber = "E001";
            s3.Category = Category.Envelope;
            s3.Description = "Envelope Brown (3\"x6\")";
            
            s3.Uom = UOM.Each;

            Stationery s4 = new Stationery();
            s4.ItemNumber = "E020";
            s4.Category = Category.Eraser;
            s4.Description = "Eraser (hard)";
            
            s4.Uom = UOM.Each;

            Stationery s5 = new Stationery();
            s5.ItemNumber = "E030";
            s5.Category = Category.Exercise;
            s5.Description = "Exercise Book (100 pg)";
            
            s5.Uom = UOM.Each;

            Stationery s6 = new Stationery();
            s6.ItemNumber = "F020";
            s6.Category = Category.File;
            s6.Description = "File Separator";
            
            s6.Uom = UOM.Set;

            Stationery s7 = new Stationery();
            s7.ItemNumber = "F021";
            s7.Category = Category.File;
            s7.Description = "File-Blue Plain";
            s7.Uom = UOM.Each;

            Stationery s8 = new Stationery();
            s8.ItemNumber = "H011";
            s8.Category = Category.Pen;
            s8.Description = "Highlighter Blue";
            s8.Uom = UOM.Box;

            Stationery s9 = new Stationery();
            s9.ItemNumber = "H031";
            s9.Category = Category.Puncher;
            s9.Description = "Hole Puncher 2 holes";
            s9.Uom = UOM.Each;

            Stationery s10 = new Stationery();
            s10.ItemNumber = "P010";
            s10.Category = Category.Pad;
            s10.Description = "Pad Postit Memo 1\"x2\"";
            s10.Uom = UOM.Packet;

            Stationery s11 = new Stationery();
            s11.ItemNumber = "P020";
            s11.Category = Category.Paper;
            s11.Description = "Paper Photostat A3";
            s11.Uom = UOM.Box;

            Stationery s12 = new Stationery();
            s12.ItemNumber = "P030";
            s12.Category = Category.Pen;
            s12.Description = "Pen Ballpoint Black";          
            s12.Uom = UOM.Dozen;

            Stationery s13 = new Stationery();
            s13.ItemNumber = "P036";
            s13.Category = Category.Pen;
            s13.Description = "Pen Transparency Permanent";            
            s13.Uom = UOM.Packet;

            Stationery s14 = new Stationery();
            s14.ItemNumber = "P038";
            s14.Category = Category.Pen;
            s14.Description = "Pen Whiteboard Marker Black";
            
            s14.Uom = UOM.Box;

            Stationery s15 = new Stationery();
            s15.ItemNumber = "P042";
            s15.Category = Category.Pen;
            s15.Description = "Pencil 2B";
            
            s15.Uom = UOM.Dozen;

            Stationery s16 = new Stationery();
            s16.ItemNumber = "R002";
            s16.Category = Category.Ruler;
            s16.Description = "Ruler 12\"";
            
            s16.Uom = UOM.Dozen;

            Stationery s17 = new Stationery();
            s17.ItemNumber = "S100";
            s17.Category = Category.Scissors;
            s17.Description = "Scissors";
            
            s17.Uom = UOM.Each;

            Stationery s18 = new Stationery();
            s18.ItemNumber = "S040";
            s18.Category = Category.Tape;
            s18.Description = "Scotch Tape";
            
            s18.Uom = UOM.Each;

            Stationery s19 = new Stationery();
            s19.ItemNumber = "S101";
            s19.Category = Category.Sharpener;
            s19.Description = "Sharpener";
          
            s19.Uom = UOM.Each;

            Stationery s20 = new Stationery();
            s20.ItemNumber = "S010";
            s20.Category = Category.Shorthand;
            s20.Description = "Shorthand Book (100 pg)";
          
            s20.Uom = UOM.Each;

            Stationery s21 = new Stationery();
            s21.ItemNumber = "S020";
            s21.Category = Category.Stapler;
            s21.Description = "Stapler No. 28";
            
            s21.Uom = UOM.Each;

            Stationery s22 = new Stationery();
            s22.ItemNumber = "T001";
            s22.Category = Category.Tacks;
            s22.Description = "Thumb Tacks Large";
          
            s22.Uom = UOM.Box;

            Stationery s23 = new Stationery();
            s23.ItemNumber = "T020";
            s23.Category = Category.Tparency;
            s23.Description = "Transparency Blue";
           
            s23.Uom = UOM.Box;

            Stationery s24 = new Stationery();
            s24.ItemNumber = "T100";
            s24.Category = Category.Tray;
            s24.Description = "Trays In/Out";
           
            s24.Uom = UOM.Set;

            dbContext.Add(s1);
            dbContext.Add(s2);
            dbContext.Add(s3);
            dbContext.Add(s4);
            dbContext.Add(s5);
            dbContext.Add(s6);
            dbContext.Add(s7);
            dbContext.Add(s8);
            dbContext.Add(s9);
            dbContext.Add(s10);
            dbContext.Add(s11);
            dbContext.Add(s12);
            dbContext.Add(s13);
            dbContext.Add(s14);
            dbContext.Add(s15);
            dbContext.Add(s16);
            dbContext.Add(s17);
            dbContext.Add(s18);
            dbContext.Add(s19);
            dbContext.Add(s20);
            dbContext.Add(s21);
            dbContext.Add(s22);
            dbContext.Add(s23);
            dbContext.Add(s24);

            // Adding Stock

            Stock st1 = new Stock();
            st1.Stationery = s1;
            st1.ReorderLevel = 20;
            st1.ReorderQty =30;
            st1.Qty = 100;

            Stock st2 = new Stock();
            st2.Stationery = s2;
            st2.ReorderLevel = 20;
            st2.ReorderQty = 30;
            st2.Qty = 100;

            Stock st3 = new Stock();
            st3.Stationery = s3;
            st3.ReorderLevel = 20;
            st3.ReorderQty = 30;
            st3.Qty = 100;

            Stock st4 = new Stock();
            st4.Stationery = s4;
            st4.ReorderLevel = 20;
            st4.ReorderQty = 30;
            st4.Qty = 100;

            Stock st5 = new Stock();
            st5.Stationery = s5;
            st5.ReorderLevel = 20;
            st5.ReorderQty = 30;
            st5.Qty = 100;

            Stock st6 = new Stock();
            st6.Stationery = s6;
            st6.ReorderLevel = 20;
            st6.ReorderQty = 30;
            st6.Qty = 100;

            Stock st7 = new Stock();
            st7.Stationery = s7;
            st7.ReorderLevel = 20;
            st7.ReorderQty = 30;
            st7.Qty = 100;

            Stock st8 = new Stock();
            st8.Stationery = s8;
            st8.ReorderLevel = 20;
            st8.ReorderQty = 30;
            st8.Qty = 100;

            Stock st9 = new Stock();
            st9.Stationery = s9;
            st9.ReorderLevel = 20;
            st9.ReorderQty = 30;
            st9.Qty = 100;

            Stock st10 = new Stock();
            st10.Stationery = s10;
            st10.ReorderLevel = 20;
            st10.ReorderQty = 30;
            st10.Qty = 100;

            Stock st11 = new Stock();
            st11.Stationery = s11;
            st11.ReorderLevel = 20;
            st11.ReorderQty = 30;
            st11.Qty = 100;

            Stock st12 = new Stock();
            st12.Stationery = s12;
            st12.Qty = 100;
            st12.ReorderLevel = 20;
            st12.ReorderQty = 30;

            Stock st13 = new Stock();
            st13.Stationery = s13;
            st13.Qty = 100;
            st13.ReorderLevel = 20;
            st13.ReorderQty = 30;

            Stock st14 = new Stock();
            st14.Stationery = s14;
            st14.Qty = 100;
            st14.ReorderLevel = 20;
            st14.ReorderQty = 30;

            Stock st15 = new Stock();
            st15.Stationery = s15;
            st15.Qty = 100;
            st15.ReorderLevel = 20;
            st15.ReorderQty = 30;

            Stock st16 = new Stock();
            st16.Stationery = s16;
            st16.Qty = 100;
            st16.ReorderLevel = 20;
            st16.ReorderQty = 30;

            Stock st17 = new Stock();
            st17.Stationery = s17;
            st17.Qty = 100;
            st17.ReorderLevel = 20;
            st17.ReorderQty = 30;

            Stock st18 = new Stock();
            st18.Stationery = s18;
            st18.Qty = 100;
            st18.ReorderLevel = 20;
            st18.ReorderQty = 30;

            Stock st19 = new Stock();
            st19.Stationery = s19;
            st19.Qty = 100;
            st19.ReorderLevel = 20;
            st19.ReorderQty = 30;

            Stock st20 = new Stock();
            st20.Stationery = s20;
            st20.Qty = 100;
            st20.ReorderLevel = 20;
            st20.ReorderQty = 30;

            Stock st21 = new Stock();
            st21.Stationery = s21;
            st21.Qty = 100;
            st21.ReorderLevel = 20;
            st21.ReorderQty = 30;

            Stock st22 = new Stock();
            st22.Stationery = s22;
            st22.Qty = 100;
            st22.ReorderLevel = 20;
            st22.ReorderQty = 30;

            Stock st23 = new Stock();
            st23.Stationery = s23;
            st23.Qty = 100;
            st23.ReorderLevel = 20;
            st23.ReorderQty = 30;

            Stock st24 = new Stock();
            st24.Stationery = s24;
            st24.Qty = 100;
            st24.ReorderLevel = 20;
            st24.ReorderQty = 30;

            dbContext.Add(st1);
            dbContext.Add(st2);
            dbContext.Add(st3);
            dbContext.Add(st4);
            dbContext.Add(st5);
            dbContext.Add(st6);
            dbContext.Add(st7);
            dbContext.Add(st8);
            dbContext.Add(st9);
            dbContext.Add(st10);
            dbContext.Add(st11);
            dbContext.Add(st12);
            dbContext.Add(st13);
            dbContext.Add(st14);
            dbContext.Add(st15);
            dbContext.Add(st16);
            dbContext.Add(st17);
            dbContext.Add(st18);
            dbContext.Add(st19);
            dbContext.Add(st20);
            dbContext.Add(st21);
            dbContext.Add(st22);
            dbContext.Add(st23);
            dbContext.Add(st24);
            
            // Adding Departments
            Department d1 = new Department();
            d1.DeptCode = "ENGL";
            d1.DeptName = "English Dept";
            d1.TelephoneNo = "874 2234";
            d1.FaxNo = "892 1456";
            d1.CollectionPoint = CollectionPoint.EngineeringSchool;

            Department d2 = new Department();
            d2.DeptCode = "CPSC";
            d2.DeptName = "Computer Science";
            d2.TelephoneNo = "890 1235";
            d2.FaxNo = "892 1457";
            d2.CollectionPoint = CollectionPoint.ManagementSchool;

            Department d3 = new Department();
            d3.DeptCode = "COMM";
            d3.DeptName = "Commerce Dept";
            d3.TelephoneNo = "874 1284";
            d3.FaxNo = "892 1256";
            d3.CollectionPoint = CollectionPoint.MedicalSchool;

            Department d4 = new Department();
            d4.DeptCode = "REGR";
            d4.DeptName = "Registrar Dept";
            d4.TelephoneNo = "890 1266";
            d4.FaxNo = "892 1465";
            d4.CollectionPoint = CollectionPoint.ScienceSchool;

            Department d5 = new Department();
            d5.DeptCode = "STORE";
            d5.DeptName = "Store Dept";
            d5.TelephoneNo = "890 1266";
            d5.FaxNo = "892 1465";

            dbContext.Add(d1);
            dbContext.Add(d2);
            dbContext.Add(d3);
            dbContext.Add(d4);
            dbContext.Add(d5);


            // Adding Employees

            Employee e1 = new Employee();
            e1.Name = "Jenny Wong Mei Lin";
            e1.Username = "employee1";
            e1.Password = Crypto.Sha256("employee1");
            e1.Dept = d1;
            e1.JobTitle = DeptRole.Employee;
            e1.Role = DeptRole.DeptRep;

            Employee e2 = new Employee();
            e2.Name = "Mrs Pamela Kow";
            e2.Username = "employee2";
            e2.Password = Crypto.Sha256("employee2");
            e2.Dept = d1;
            e2.JobTitle = DeptRole.Employee;
            e2.Role = DeptRole.Contact;

            Employee e3 = new Employee();
            e3.Name = "Prof Ezra Pound";
            e3.Username = "depthead";
            e3.Password = Crypto.Sha256("depthead");
            e3.Dept = d1;
            e3.JobTitle = DeptRole.DeptHead;
            e3.Role = DeptRole.DeptHead;

            Employee e4 = new Employee();
            e4.Name = "Mrs Jane Koh";
            e4.Username = "storeclerk";
            e4.Password = Crypto.Sha256("storeclerk");
            e4.Dept = d5;
            e4.JobTitle = DeptRole.StoreClerk;
            e4.Role = DeptRole.StoreClerk;

            Employee e5 = new Employee();
            e5.Name = "Mr Gary Lim";
            e5.Username = "supervisor";
            e5.Password = Crypto.Sha256("supervisor");
            e5.Dept = d5;
            e5.JobTitle = DeptRole.StoreSupervisor;
            e5.Role = DeptRole.StoreSupervisor;

            Employee e6 = new Employee();
            e6.Name = "Mrs Marilyn Monroe";
            e6.Username = "manager";
            e6.Password = Crypto.Sha256("manager");
            e6.Dept = d5;
            e6.JobTitle = DeptRole.StoreSupervisor;
            e6.Role = DeptRole.StoreSupervisor;



            dbContext.Add(e1);
            dbContext.Add(e2);
            dbContext.Add(e3);
            dbContext.Add(e4);
            dbContext.Add(e5);
            dbContext.Add(e6);
            
            // Adding Requisition

            DeptRequisition dr1 = new DeptRequisition();
            dr1.Employee = e1;
            dr1.RequisitionApprovalStatus = RequisitionApprovalStatus.Pending;

            DeptRequisition dr2 = new DeptRequisition();
            dr2.Employee = e1;
            dr2.RequisitionApprovalStatus = RequisitionApprovalStatus.Pending;

            DeptRequisition dr3 = new DeptRequisition();
            dr3.Employee = e1;
            dr3.RequisitionApprovalStatus = RequisitionApprovalStatus.Pending;

            DeptRequisition dr4 = new DeptRequisition();
            dr4.Employee = e1;
            dr4.RequisitionApprovalStatus = RequisitionApprovalStatus.Approved;
            dr4.RequisitionFulfillmentStatus = RequisitionFulfillmentStatus.ToBeProcessed;

            DeptRequisition dr5 = new DeptRequisition();
            dr5.Employee = e1;
            dr5.RequisitionApprovalStatus = RequisitionApprovalStatus.Approved;
            dr5.RequisitionFulfillmentStatus = RequisitionFulfillmentStatus.ToBeProcessed;

            DeptRequisition dr6 = new DeptRequisition();
            dr6.Employee = e1;
            dr6.RequisitionApprovalStatus = RequisitionApprovalStatus.Approved;
            dr6.RequisitionFulfillmentStatus = RequisitionFulfillmentStatus.ToBeProcessed;

            DeptRequisition dr7 = new DeptRequisition();
            dr7.Employee = e1;
            dr7.RequisitionApprovalStatus = RequisitionApprovalStatus.Rejected;

            DeptRequisition dr8 = new DeptRequisition();
            dr8.Employee = e1;
            dr8.RequisitionApprovalStatus = RequisitionApprovalStatus.Rejected;

            DeptRequisition dr9 = new DeptRequisition();
            dr9.Employee = e1;
            dr9.RequisitionApprovalStatus = RequisitionApprovalStatus.Rejected;

            dbContext.Add(dr1);
            dbContext.Add(dr2);
            dbContext.Add(dr3);
            dbContext.Add(dr4);
            dbContext.Add(dr5);
            dbContext.Add(dr6);
            dbContext.Add(dr7);
            dbContext.Add(dr8);
            dbContext.Add(dr9);

            // Adding Requisition Details

            RequisitionDetail rd1 = new RequisitionDetail();
            rd1.Stationery = s1;
            rd1.Qty = 10;
            rd1.DeptRequisition = dr1;

            RequisitionDetail rd2 = new RequisitionDetail();
            rd2.Stationery = s3;
            rd2.Qty = 45;
            rd2.DeptRequisition = dr1;

            RequisitionDetail rd3 = new RequisitionDetail();
            rd3.Stationery = s5;
            rd3.Qty = 100;
            rd3.DeptRequisition = dr1;

            RequisitionDetail rd4 = new RequisitionDetail();
            rd4.Stationery = s7;
            rd4.Qty = 25;
            rd4.DeptRequisition = dr1;

            RequisitionDetail rd5 = new RequisitionDetail();
            rd5.Stationery = s9;
            rd5.Qty = 25;
            rd5.DeptRequisition = dr1;

            dbContext.Add(rd1);
            dbContext.Add(rd2);
            dbContext.Add(rd3);
            dbContext.Add(rd4);
            dbContext.Add(rd5);

            RequisitionDetail rd6 = new RequisitionDetail();
            rd6.Stationery = s1;
            rd6.Qty = 10;
            rd6.DeptRequisition = dr2;

            RequisitionDetail rd7 = new RequisitionDetail();
            rd7.Stationery = s3;
            rd7.Qty = 45;
            rd7.DeptRequisition = dr3;

            RequisitionDetail rd8 = new RequisitionDetail();
            rd8.Stationery = s5;
            rd8.Qty = 100;
            rd8.DeptRequisition = dr4;

            RequisitionDetail rd9 = new RequisitionDetail();
            rd9.Stationery = s7;
            rd9.Qty = 25;
            rd9.DeptRequisition = dr5;

            RequisitionDetail rd10 = new RequisitionDetail();
            rd10.Stationery = s9;
            rd10.Qty = 25;
            rd10.DeptRequisition = dr6;

            RequisitionDetail rd11 = new RequisitionDetail();
            rd11.Stationery = s9;
            rd11.Qty = 25;
            rd11.DeptRequisition = dr7;

            RequisitionDetail rd12 = new RequisitionDetail();
            rd12.Stationery = s9;
            rd12.Qty = 25;
            rd12.DeptRequisition = dr8;

            RequisitionDetail rd13 = new RequisitionDetail();
            rd13.Stationery = s9;
            rd13.Qty = 25;
            rd13.DeptRequisition = dr9;

            dbContext.Add(rd6);
            dbContext.Add(rd7);
            dbContext.Add(rd8);
            dbContext.Add(rd9);
            dbContext.Add(rd10);
            dbContext.Add(rd11);
            dbContext.Add(rd12);
            dbContext.Add(rd13);

            // Add Supplier
            Supplier su1 = new Supplier();
            su1.Name = "FairPrice";
            su1.TelephoneNo= "8668 8668";
            su1.Address = "Ang Mo Kio";

            Supplier su2 = new Supplier();
            su2.Name = "ColdStorage";
            su2.TelephoneNo = "8224 4228";
            su2.Address = "Kovan";

            Supplier su3 = new Supplier();
            su3.Name = "Metro";
            su3.TelephoneNo = "8112 2118";
            su3.Address = "Marina Bay";

            Supplier su4 = new Supplier();
            su4.Name = "Giant";
            su4.TelephoneNo = "8334 4338";
            su4.Address = "Bukit Batok";

            Supplier su5 = new Supplier();
            su5.Name = "Citimart";
            su5.TelephoneNo = "86664 4668";
            su5.Address = "Jurong East";

            dbContext.Add(su1);
            dbContext.Add(su2);
            dbContext.Add(su3);
            dbContext.Add(su4);
            dbContext.Add(su5);

            //Add SupplierDetail
            SupplierDetail suD1 = new SupplierDetail();
            suD1.Stationery = s1;
            suD1.Supplier = su1;
            suD1.UnitPrice = 10;

            SupplierDetail suD2 = new SupplierDetail();
            suD2.Stationery = s2;
            suD2.Supplier = su1;
            suD2.UnitPrice = 15;

            SupplierDetail suD3 = new SupplierDetail();
            suD3.Stationery = s3;
            suD3.Supplier = su2;
            suD3.UnitPrice = 18;

            SupplierDetail suD4 = new SupplierDetail();
            suD4.Stationery = s4;
            suD4.Supplier = su2;
            suD4.UnitPrice = 10;

            SupplierDetail suD5 = new SupplierDetail();
            suD5.Stationery = s5;
            suD5.Supplier = su3;
            suD5.UnitPrice = 12;

            SupplierDetail suD6 = new SupplierDetail();
            suD6.Stationery = s6;
            suD6.Supplier = su4;
            suD6.UnitPrice = 10;

            SupplierDetail suD7 = new SupplierDetail();
            suD7.Stationery = s7;
            suD7.Supplier = su4;
            suD7.UnitPrice = 15;

            SupplierDetail suD8 = new SupplierDetail();
            suD8.Stationery = s8;
            suD8.Supplier = su5;
            suD8.UnitPrice = 10;

            SupplierDetail suD9 = new SupplierDetail();
            suD9.Stationery = s9;
            suD9.Supplier = su5;
            suD9.UnitPrice = 20;

            dbContext.Add(suD1);
            dbContext.Add(suD2);
            dbContext.Add(suD3);
            dbContext.Add(suD4);
            dbContext.Add(suD5);
            dbContext.Add(suD6);
            dbContext.Add(suD7);
            dbContext.Add(suD8);
            dbContext.Add(suD9);

            //Add PO
            PO po1 = new PO();
            po1.OrderDate = new DateTime(2020, 10, 10);
            po1.POStatus = POStatus.Submitted;
            po1.Supplier = su1;

            PO po2 = new PO();
            po2.OrderDate = new DateTime(2020, 8, 20);
            po2.POStatus = POStatus.Submitted;
            po2.Supplier = su2;

            dbContext.Add(po1);
            dbContext.Add(po2);


            //Add PODetail
            PODetail poD1 = new PODetail();
            poD1.Qty = 10;
            poD1.SupplierDetail = suD1;
            poD1.PO = po1;
            poD1.SupplierDetail.UnitPrice = 10;

            PODetail poD2 = new PODetail();
            poD2.Qty = 20;
            poD2.SupplierDetail = suD2;
            poD2.PO = po1;
            poD2.SupplierDetail.UnitPrice = 10;

            PODetail poD3 = new PODetail();
            poD3.Qty = 10;
            poD3.SupplierDetail = suD3;
            poD3.PO = po2;
            poD3.SupplierDetail.UnitPrice = 10;

            PODetail poD4 = new PODetail();
            poD4.Qty = 30;
            poD4.SupplierDetail = suD4;
            poD4.PO = po2;
            poD4.SupplierDetail.UnitPrice = 10;

            dbContext.Add(poD1);
            dbContext.Add(poD2);
            dbContext.Add(poD3);
            dbContext.Add(poD4);
            // Saving Changes

            dbContext.SaveChanges();
        }
    }
}
