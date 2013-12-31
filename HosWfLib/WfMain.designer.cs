using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

using Hos.WorkFlow.LocalServices;

namespace Hos.WorkFlow
{
    partial class WfMain
    {
        #region Designer generated code

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference1 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference2 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference3 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference4 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition2 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition3 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition4 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition5 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.CodeCondition codecondition6 = new System.Workflow.Activities.CodeCondition();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference5 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.Activities.Rules.RuleConditionReference ruleconditionreference6 = new System.Workflow.Activities.Rules.RuleConditionReference();
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding3 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind3 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding4 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            this.转至离开 = new System.Workflow.Activities.SetStateActivity();
            this.转至拿药 = new System.Workflow.Activities.SetStateActivity();
            this.无需拿药 = new System.Workflow.Activities.IfElseBranchActivity();
            this.确认拿药 = new System.Workflow.Activities.IfElseBranchActivity();
            this.是否拿药 = new System.Workflow.Activities.IfElseActivity();
            this.转至住院 = new System.Workflow.Activities.SetStateActivity();
            this.无需住院 = new System.Workflow.Activities.IfElseBranchActivity();
            this.确认住院 = new System.Workflow.Activities.IfElseBranchActivity();
            this.暂时转换至离开医院 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity7 = new System.Workflow.Activities.CodeActivity();
            this.转换到离院状态 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity6 = new System.Workflow.Activities.CodeActivity();
            this.转换至挂号状态 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity4 = new System.Workflow.Activities.CodeActivity();
            this.转换至手术状态 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity3 = new System.Workflow.Activities.CodeActivity();
            this.转换至拿药状态 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity2 = new System.Workflow.Activities.CodeActivity();
            this.转换至住院状态 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity5 = new System.Workflow.Activities.CodeActivity();
            this.是否住院 = new System.Workflow.Activities.IfElseActivity();
            this.发送消息 = new System.Workflow.Activities.CodeActivity();
            this.继续治疗 = new System.Workflow.Activities.IfElseBranchActivity();
            this.离院 = new System.Workflow.Activities.IfElseBranchActivity();
            this.至挂号 = new System.Workflow.Activities.IfElseBranchActivity();
            this.至手术 = new System.Workflow.Activities.IfElseBranchActivity();
            this.至拿药 = new System.Workflow.Activities.IfElseBranchActivity();
            this.至住院 = new System.Workflow.Activities.IfElseBranchActivity();
            this.无需换诊 = new System.Workflow.Activities.IfElseBranchActivity();
            this.确认换诊 = new System.Workflow.Activities.IfElseBranchActivity();
            this.codeActivity8 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity3 = new System.Workflow.Activities.SetStateActivity();
            this.初始化 = new System.Workflow.Activities.CodeActivity();
            this.判断是否离院 = new System.Workflow.Activities.IfElseActivity();
            this.处理开医嘱完成 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.进入挂号状态 = new System.Workflow.Activities.CodeActivity();
            this.转换至就诊状态 = new System.Workflow.Activities.SetStateActivity();
            this.处理挂号完成 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.处理初始化 = new System.Workflow.Activities.CodeActivity();
            this.收费完成后去向 = new System.Workflow.Activities.IfElseActivity();
            this.处理收费完成 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.是否换诊 = new System.Workflow.Activities.IfElseActivity();
            this.接收子工作流就诊完成 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.调用Treat子工作流 = new System.Workflow.Activities.InvokeWebServiceActivity();
            this.转换到收费 = new System.Workflow.Activities.SetStateActivity();
            this.stateInitializationActivity4 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity3 = new System.Workflow.Activities.StateInitializationActivity();
            this.开医嘱状态初始化 = new System.Workflow.Activities.StateInitializationActivity();
            this.开医嘱完成 = new System.Workflow.Activities.EventDrivenActivity();
            this.挂号初始化 = new System.Workflow.Activities.StateInitializationActivity();
            this.挂号完成处理 = new System.Workflow.Activities.EventDrivenActivity();
            this.stateInitializationActivity2 = new System.Workflow.Activities.StateInitializationActivity();
            this.stateInitializationActivity1 = new System.Workflow.Activities.StateInitializationActivity();
            this.收费状态初始化 = new System.Workflow.Activities.StateInitializationActivity();
            this.收费完成 = new System.Workflow.Activities.EventDrivenActivity();
            this.就诊完成 = new System.Workflow.Activities.EventDrivenActivity();
            this.就诊状态初始化 = new System.Workflow.Activities.StateInitializationActivity();
            this.开始工作流 = new System.Workflow.Activities.StateInitializationActivity();
            this.离开医院 = new System.Workflow.Activities.StateActivity();
            this.手术 = new System.Workflow.Activities.StateActivity();
            this.开医嘱状态 = new System.Workflow.Activities.StateActivity();
            this.挂号 = new System.Workflow.Activities.StateActivity();
            this.拿药状态 = new System.Workflow.Activities.StateActivity();
            this.住院状态 = new System.Workflow.Activities.StateActivity();
            this.收费 = new System.Workflow.Activities.StateActivity();
            this.就诊 = new System.Workflow.Activities.StateActivity();
            this.Workflow1InitialState = new System.Workflow.Activities.StateActivity();
            // 
            // 转至离开
            // 
            this.转至离开.Name = "转至离开";
            this.转至离开.TargetStateName = "离开医院";
            // 
            // 转至拿药
            // 
            this.转至拿药.Name = "转至拿药";
            this.转至拿药.TargetStateName = "拿药状态";
            // 
            // 无需拿药
            // 
            this.无需拿药.Activities.Add(this.转至离开);
            ruleconditionreference1.ConditionName = "条件6";
            this.无需拿药.Condition = ruleconditionreference1;
            this.无需拿药.Name = "无需拿药";
            // 
            // 确认拿药
            // 
            this.确认拿药.Activities.Add(this.转至拿药);
            ruleconditionreference2.ConditionName = "条件5";
            this.确认拿药.Condition = ruleconditionreference2;
            this.确认拿药.Name = "确认拿药";
            // 
            // 是否拿药
            // 
            this.是否拿药.Activities.Add(this.确认拿药);
            this.是否拿药.Activities.Add(this.无需拿药);
            this.是否拿药.Name = "是否拿药";
            // 
            // 转至住院
            // 
            this.转至住院.Name = "转至住院";
            this.转至住院.TargetStateName = "住院状态";
            // 
            // 无需住院
            // 
            this.无需住院.Activities.Add(this.是否拿药);
            ruleconditionreference3.ConditionName = "条件4";
            this.无需住院.Condition = ruleconditionreference3;
            this.无需住院.Name = "无需住院";
            // 
            // 确认住院
            // 
            this.确认住院.Activities.Add(this.转至住院);
            ruleconditionreference4.ConditionName = "条件3";
            this.确认住院.Condition = ruleconditionreference4;
            this.确认住院.Name = "确认住院";
            // 
            // 暂时转换至离开医院
            // 
            this.暂时转换至离开医院.Name = "暂时转换至离开医院";
            this.暂时转换至离开医院.TargetStateName = "离开医院";
            // 
            // codeActivity7
            // 
            this.codeActivity7.Name = "codeActivity7";
            this.codeActivity7.ExecuteCode += new System.EventHandler(this.codeActivity7_ExecuteCode);
            // 
            // 转换到离院状态
            // 
            this.转换到离院状态.Name = "转换到离院状态";
            this.转换到离院状态.TargetStateName = "离开医院";
            // 
            // codeActivity6
            // 
            this.codeActivity6.Name = "codeActivity6";
            this.codeActivity6.ExecuteCode += new System.EventHandler(this.codeActivity6_ExecuteCode);
            // 
            // 转换至挂号状态
            // 
            this.转换至挂号状态.Name = "转换至挂号状态";
            this.转换至挂号状态.TargetStateName = "挂号";
            // 
            // codeActivity4
            // 
            this.codeActivity4.Name = "codeActivity4";
            this.codeActivity4.ExecuteCode += new System.EventHandler(this.拿药分支_ExecuteCode);
            // 
            // 转换至手术状态
            // 
            this.转换至手术状态.Name = "转换至手术状态";
            this.转换至手术状态.TargetStateName = "手术";
            // 
            // codeActivity3
            // 
            this.codeActivity3.Name = "codeActivity3";
            this.codeActivity3.ExecuteCode += new System.EventHandler(this.拿药分支_ExecuteCode);
            // 
            // 转换至拿药状态
            // 
            this.转换至拿药状态.Name = "转换至拿药状态";
            this.转换至拿药状态.TargetStateName = "拿药状态";
            // 
            // codeActivity2
            // 
            this.codeActivity2.Name = "codeActivity2";
            this.codeActivity2.ExecuteCode += new System.EventHandler(this.拿药分支_ExecuteCode);
            // 
            // 转换至住院状态
            // 
            this.转换至住院状态.Name = "转换至住院状态";
            this.转换至住院状态.TargetStateName = "住院状态";
            // 
            // codeActivity5
            // 
            this.codeActivity5.Name = "codeActivity5";
            this.codeActivity5.ExecuteCode += new System.EventHandler(this.拿药分支_ExecuteCode);
            // 
            // 是否住院
            // 
            this.是否住院.Activities.Add(this.确认住院);
            this.是否住院.Activities.Add(this.无需住院);
            this.是否住院.Name = "是否住院";
            // 
            // 发送消息
            // 
            this.发送消息.Name = "发送消息";
            this.发送消息.ExecuteCode += new System.EventHandler(this.发送消息_ExecuteCode);
            // 
            // 继续治疗
            // 
            this.继续治疗.Activities.Add(this.codeActivity7);
            this.继续治疗.Activities.Add(this.暂时转换至离开医院);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfNotLeaveHospital);
            this.继续治疗.Condition = codecondition1;
            this.继续治疗.Name = "继续治疗";
            // 
            // 离院
            // 
            this.离院.Activities.Add(this.codeActivity6);
            this.离院.Activities.Add(this.转换到离院状态);
            codecondition2.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfLeaveHospital);
            this.离院.Condition = codecondition2;
            this.离院.Name = "离院";
            // 
            // 至挂号
            // 
            this.至挂号.Activities.Add(this.codeActivity4);
            this.至挂号.Activities.Add(this.转换至挂号状态);
            codecondition3.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfRegisterCondition);
            this.至挂号.Condition = codecondition3;
            this.至挂号.Description = "ifToRegiste";
            this.至挂号.Name = "至挂号";
            // 
            // 至手术
            // 
            this.至手术.Activities.Add(this.codeActivity3);
            this.至手术.Activities.Add(this.转换至手术状态);
            codecondition4.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfOperatedCondition);
            this.至手术.Condition = codecondition4;
            this.至手术.Name = "至手术";
            // 
            // 至拿药
            // 
            this.至拿药.Activities.Add(this.codeActivity2);
            this.至拿药.Activities.Add(this.转换至拿药状态);
            codecondition5.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfMedicineCondition);
            this.至拿药.Condition = codecondition5;
            this.至拿药.Name = "至拿药";
            // 
            // 至住院
            // 
            this.至住院.Activities.Add(this.codeActivity5);
            this.至住院.Activities.Add(this.转换至住院状态);
            codecondition6.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.IfHospitaledCondition);
            this.至住院.Condition = codecondition6;
            this.至住院.Name = "至住院";
            // 
            // 无需换诊
            // 
            this.无需换诊.Activities.Add(this.是否住院);
            ruleconditionreference5.ConditionName = "条件2";
            this.无需换诊.Condition = ruleconditionreference5;
            this.无需换诊.Name = "无需换诊";
            // 
            // 确认换诊
            // 
            this.确认换诊.Activities.Add(this.发送消息);
            ruleconditionreference6.ConditionName = "条件1";
            this.确认换诊.Condition = ruleconditionreference6;
            this.确认换诊.Name = "确认换诊";
            // 
            // codeActivity8
            // 
            this.codeActivity8.Name = "codeActivity8";
            this.codeActivity8.ExecuteCode += new System.EventHandler(this.codeActivity8_ExecuteCode);
            // 
            // setStateActivity3
            // 
            this.setStateActivity3.Name = "setStateActivity3";
            this.setStateActivity3.TargetStateName = "离开医院";
            // 
            // 初始化
            // 
            this.初始化.Name = "初始化";
            this.初始化.ExecuteCode += new System.EventHandler(this.初始化_ExecuteCode);
            // 
            // 判断是否离院
            // 
            this.判断是否离院.Activities.Add(this.离院);
            this.判断是否离院.Activities.Add(this.继续治疗);
            this.判断是否离院.Name = "判断是否离院";
            // 
            // 处理开医嘱完成
            // 
            this.处理开医嘱完成.EventName = "MedicalAdviceCompleted";
            this.处理开医嘱完成.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.处理开医嘱完成.Name = "处理开医嘱完成";
            this.处理开医嘱完成.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.处理开医嘱完成_Invoked);
            // 
            // 进入挂号状态
            // 
            this.进入挂号状态.Name = "进入挂号状态";
            this.进入挂号状态.ExecuteCode += new System.EventHandler(this.进入挂号状态_ExecuteCode);
            // 
            // 转换至就诊状态
            // 
            this.转换至就诊状态.Name = "转换至就诊状态";
            this.转换至就诊状态.TargetStateName = "就诊";
            // 
            // 处理挂号完成
            // 
            this.处理挂号完成.EventName = "RegisterCompleted";
            this.处理挂号完成.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.处理挂号完成.Name = "处理挂号完成";
            this.处理挂号完成.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.处理挂号完成_Invoked);
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "离开医院";
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.拿药分支_ExecuteCode);
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "离开医院";
            // 
            // 处理初始化
            // 
            this.处理初始化.Name = "处理初始化";
            this.处理初始化.ExecuteCode += new System.EventHandler(this.处理初始化_ExecuteCode);
            // 
            // 收费完成后去向
            // 
            this.收费完成后去向.Activities.Add(this.至住院);
            this.收费完成后去向.Activities.Add(this.至拿药);
            this.收费完成后去向.Activities.Add(this.至手术);
            this.收费完成后去向.Activities.Add(this.至挂号);
            this.收费完成后去向.Name = "收费完成后去向";
            // 
            // 处理收费完成
            // 
            this.处理收费完成.EventName = "ChargeCompleted";
            this.处理收费完成.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.处理收费完成.Name = "处理收费完成";
            this.处理收费完成.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.处理收费完成_Invoked);
            // 
            // 是否换诊
            // 
            this.是否换诊.Activities.Add(this.确认换诊);
            this.是否换诊.Activities.Add(this.无需换诊);
            this.是否换诊.Name = "是否换诊";
            // 
            // 接收子工作流就诊完成
            // 
            this.接收子工作流就诊完成.EventName = "DiagnoseCompleted";
            this.接收子工作流就诊完成.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.接收子工作流就诊完成.Name = "接收子工作流就诊完成";
            activitybind1.Name = "WfMain";
            activitybind1.Path = "diagnoseCompletedArgs";
            workflowparameterbinding1.ParameterName = "e";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.接收子工作流就诊完成.ParameterBindings.Add(workflowparameterbinding1);
            this.接收子工作流就诊完成.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.处理就诊完成_Invoked_1);
            // 
            // 调用Treat子工作流
            // 
            this.调用Treat子工作流.MethodName = "stratTreatWf";
            this.调用Treat子工作流.Name = "调用Treat子工作流";
            activitybind2.Name = "WfMain";
            activitybind2.Path = "patientGuidID";
            workflowparameterbinding2.ParameterName = "patientGuidID";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            workflowparameterbinding3.ParameterName = "(ReturnValue)";
            workflowparameterbinding3.Value = "\"成功鸟\"";
            activitybind3.Name = "WfMain";
            activitybind3.Path = "patientStrID";
            workflowparameterbinding4.ParameterName = "patientStrID";
            workflowparameterbinding4.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind3)));
            this.调用Treat子工作流.ParameterBindings.Add(workflowparameterbinding2);
            this.调用Treat子工作流.ParameterBindings.Add(workflowparameterbinding3);
            this.调用Treat子工作流.ParameterBindings.Add(workflowparameterbinding4);
            this.调用Treat子工作流.ProxyClass = typeof(Hos.WorkFlow.DiagnoseService.DiagnoseService);
            // 
            // 转换到收费
            // 
            this.转换到收费.Name = "转换到收费";
            this.转换到收费.TargetStateName = "收费";
            // 
            // stateInitializationActivity4
            // 
            this.stateInitializationActivity4.Activities.Add(this.codeActivity8);
            this.stateInitializationActivity4.Name = "stateInitializationActivity4";
            // 
            // stateInitializationActivity3
            // 
            this.stateInitializationActivity3.Activities.Add(this.setStateActivity3);
            this.stateInitializationActivity3.Name = "stateInitializationActivity3";
            // 
            // 开医嘱状态初始化
            // 
            this.开医嘱状态初始化.Activities.Add(this.初始化);
            this.开医嘱状态初始化.Name = "开医嘱状态初始化";
            // 
            // 开医嘱完成
            // 
            this.开医嘱完成.Activities.Add(this.处理开医嘱完成);
            this.开医嘱完成.Activities.Add(this.判断是否离院);
            this.开医嘱完成.Name = "开医嘱完成";
            // 
            // 挂号初始化
            // 
            this.挂号初始化.Activities.Add(this.进入挂号状态);
            this.挂号初始化.Name = "挂号初始化";
            // 
            // 挂号完成处理
            // 
            this.挂号完成处理.Activities.Add(this.处理挂号完成);
            this.挂号完成处理.Activities.Add(this.转换至就诊状态);
            this.挂号完成处理.Name = "挂号完成处理";
            // 
            // stateInitializationActivity2
            // 
            this.stateInitializationActivity2.Activities.Add(this.codeActivity1);
            this.stateInitializationActivity2.Activities.Add(this.setStateActivity2);
            this.stateInitializationActivity2.Name = "stateInitializationActivity2";
            // 
            // stateInitializationActivity1
            // 
            this.stateInitializationActivity1.Activities.Add(this.setStateActivity1);
            this.stateInitializationActivity1.Name = "stateInitializationActivity1";
            // 
            // 收费状态初始化
            // 
            this.收费状态初始化.Activities.Add(this.处理初始化);
            this.收费状态初始化.Name = "收费状态初始化";
            // 
            // 收费完成
            // 
            this.收费完成.Activities.Add(this.处理收费完成);
            this.收费完成.Activities.Add(this.收费完成后去向);
            this.收费完成.Name = "收费完成";
            // 
            // 就诊完成
            // 
            this.就诊完成.Activities.Add(this.接收子工作流就诊完成);
            this.就诊完成.Activities.Add(this.是否换诊);
            this.就诊完成.Name = "就诊完成";
            // 
            // 就诊状态初始化
            // 
            this.就诊状态初始化.Activities.Add(this.调用Treat子工作流);
            this.就诊状态初始化.Name = "就诊状态初始化";
            // 
            // 开始工作流
            // 
            this.开始工作流.Activities.Add(this.转换到收费);
            this.开始工作流.Name = "开始工作流";
            // 
            // 离开医院
            // 
            this.离开医院.Activities.Add(this.stateInitializationActivity4);
            this.离开医院.Name = "离开医院";
            // 
            // 手术
            // 
            this.手术.Activities.Add(this.stateInitializationActivity3);
            this.手术.Name = "手术";
            // 
            // 开医嘱状态
            // 
            this.开医嘱状态.Activities.Add(this.开医嘱完成);
            this.开医嘱状态.Activities.Add(this.开医嘱状态初始化);
            this.开医嘱状态.Name = "开医嘱状态";
            // 
            // 挂号
            // 
            this.挂号.Activities.Add(this.挂号完成处理);
            this.挂号.Activities.Add(this.挂号初始化);
            this.挂号.Name = "挂号";
            // 
            // 拿药状态
            // 
            this.拿药状态.Activities.Add(this.stateInitializationActivity2);
            this.拿药状态.Name = "拿药状态";
            // 
            // 住院状态
            // 
            this.住院状态.Activities.Add(this.stateInitializationActivity1);
            this.住院状态.Name = "住院状态";
            // 
            // 收费
            // 
            this.收费.Activities.Add(this.收费完成);
            this.收费.Activities.Add(this.收费状态初始化);
            this.收费.Name = "收费";
            // 
            // 就诊
            // 
            this.就诊.Activities.Add(this.就诊状态初始化);
            this.就诊.Activities.Add(this.就诊完成);
            this.就诊.Name = "就诊";
            // 
            // Workflow1InitialState
            // 
            this.Workflow1InitialState.Activities.Add(this.开始工作流);
            this.Workflow1InitialState.Name = "Workflow1InitialState";
            // 
            // WfMain
            // 
            this.Activities.Add(this.Workflow1InitialState);
            this.Activities.Add(this.就诊);
            this.Activities.Add(this.收费);
            this.Activities.Add(this.住院状态);
            this.Activities.Add(this.拿药状态);
            this.Activities.Add(this.挂号);
            this.Activities.Add(this.开医嘱状态);
            this.Activities.Add(this.手术);
            this.Activities.Add(this.离开医院);
            this.CompletedStateName = null;
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "Workflow1InitialState";
            this.Name = "WfMain";
            this.CanModifyActivities = false;

        }

        #endregion

        private IfElseBranchActivity 无需换诊;
        private IfElseBranchActivity 确认换诊;
        private IfElseActivity 是否换诊;
        private CodeActivity 发送消息;
        private IfElseBranchActivity 无需住院;
        private IfElseBranchActivity 确认住院;
        private IfElseActivity 是否住院;
        private IfElseBranchActivity 无需拿药;
        private IfElseBranchActivity 确认拿药;
        private IfElseActivity 是否拿药;
        private SetStateActivity 转至离开;
        private SetStateActivity 转至拿药;
        private SetStateActivity 转至住院;
        private InvokeWebServiceActivity 调用Treat子工作流;
        private CodeActivity codeActivity8;
        private StateInitializationActivity stateInitializationActivity4;
        private CodeActivity codeActivity7;
        private CodeActivity codeActivity6;
        private CodeActivity 进入挂号状态;
        private StateInitializationActivity 挂号初始化;
        private CodeActivity codeActivity2;
        private CodeActivity codeActivity4;
        private CodeActivity codeActivity3;
        private CodeActivity codeActivity5;
        private CodeActivity codeActivity1;
        private CodeActivity 初始化;
        private CodeActivity 处理初始化;
        private StateInitializationActivity 收费状态初始化;
        private SetStateActivity setStateActivity3;
        private SetStateActivity setStateActivity2;
        private SetStateActivity setStateActivity1;
        private StateInitializationActivity stateInitializationActivity3;
        private StateInitializationActivity stateInitializationActivity2;
        private StateInitializationActivity stateInitializationActivity1;
        private SetStateActivity 暂时转换至离开医院;
        private SetStateActivity 转换到离院状态;
        private StateActivity 离开医院;
        private IfElseBranchActivity 继续治疗;
        private IfElseBranchActivity 离院;
        private IfElseActivity 判断是否离院;
        private StateInitializationActivity 开医嘱状态初始化;
        private SetStateActivity 转换至挂号状态;
        private StateActivity 开医嘱状态;
        private SetStateActivity 转换至就诊状态;
        private EventDrivenActivity 开医嘱完成;
        private HandleExternalEventActivity 处理开医嘱完成;
        private SetStateActivity 转换到收费;
        private StateActivity 手术;
        private IfElseBranchActivity 至挂号;
        private HandleExternalEventActivity 接收子工作流就诊完成;
        private EventDrivenActivity 就诊完成;
        private SetStateActivity 转换至手术状态;
        private HandleExternalEventActivity 处理挂号完成;
        private EventDrivenActivity 挂号完成处理;
        private StateActivity 挂号;
        private StateInitializationActivity 就诊状态初始化;
        private SetStateActivity 转换至住院状态;
        private StateActivity 住院状态;
        private SetStateActivity 转换至拿药状态;
        private IfElseBranchActivity 至手术;
        private StateActivity 拿药状态;
        private StateActivity 就诊;
        private StateInitializationActivity 开始工作流;
        private StateActivity 收费;
        private EventDrivenActivity 收费完成;
        private HandleExternalEventActivity 处理收费完成;
        private IfElseBranchActivity 至拿药;
        private IfElseBranchActivity 至住院;
        private IfElseActivity 收费完成后去向;
        private StateActivity Workflow1InitialState;


























































































































































































































































































































































    }
}
