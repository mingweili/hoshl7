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

namespace Hos.WorkFlow
{
    partial class WfTreat
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
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding1 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.WorkflowParameterBinding workflowparameterbinding2 = new System.Workflow.ComponentModel.WorkflowParameterBinding();
            this.分诊至其他 = new System.Workflow.Activities.IfElseBranchActivity();
            this.分诊至肠胃科 = new System.Workflow.Activities.IfElseBranchActivity();
            this.通知主工作流结束 = new System.Workflow.Activities.CodeActivity();
            this.接收就诊结果 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.setStateActivity2 = new System.Workflow.Activities.SetStateActivity();
            this.分诊分支 = new System.Workflow.Activities.IfElseActivity();
            this.接收分诊结果 = new System.Workflow.Activities.HandleExternalEventActivity();
            this.setStateActivity1 = new System.Workflow.Activities.SetStateActivity();
            this.等待就诊完成 = new System.Workflow.Activities.EventDrivenActivity();
            this.等待分诊结果 = new System.Workflow.Activities.EventDrivenActivity();
            this.初始化 = new System.Workflow.Activities.StateInitializationActivity();
            this.就诊 = new System.Workflow.Activities.StateActivity();
            this.分诊 = new System.Workflow.Activities.StateActivity();
            this.初始状态 = new System.Workflow.Activities.StateActivity();
            // 
            // 分诊至其他
            // 
            ruleconditionreference1.ConditionName = "条件2";
            this.分诊至其他.Condition = ruleconditionreference1;
            this.分诊至其他.Name = "分诊至其他";
            // 
            // 分诊至肠胃科
            // 
            ruleconditionreference2.ConditionName = "条件1";
            this.分诊至肠胃科.Condition = ruleconditionreference2;
            this.分诊至肠胃科.Name = "分诊至肠胃科";
            // 
            // 通知主工作流结束
            // 
            this.通知主工作流结束.Name = "通知主工作流结束";
            this.通知主工作流结束.ExecuteCode += new System.EventHandler(this.通知主工作流结束_ExecuteCode);
            // 
            // 接收就诊结果
            // 
            this.接收就诊结果.EventName = "DiagnoseCompleted";
            this.接收就诊结果.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.接收就诊结果.Name = "接收就诊结果";
            activitybind1.Name = "WfTreat";
            activitybind1.Path = "diagnoseCompletedEventArgs";
            workflowparameterbinding1.ParameterName = "e";
            workflowparameterbinding1.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.接收就诊结果.ParameterBindings.Add(workflowparameterbinding1);
            this.接收就诊结果.Invoked += new System.EventHandler<System.Workflow.Activities.ExternalDataEventArgs>(this.接收就诊结果_Invoked);
            // 
            // setStateActivity2
            // 
            this.setStateActivity2.Name = "setStateActivity2";
            this.setStateActivity2.TargetStateName = "就诊";
            // 
            // 分诊分支
            // 
            this.分诊分支.Activities.Add(this.分诊至肠胃科);
            this.分诊分支.Activities.Add(this.分诊至其他);
            this.分诊分支.Name = "分诊分支";
            // 
            // 接收分诊结果
            // 
            this.接收分诊结果.EventName = "TriageCompleted";
            this.接收分诊结果.InterfaceType = typeof(Hos.WorkFlow.LocalServices.IWfLocalServices);
            this.接收分诊结果.Name = "接收分诊结果";
            activitybind2.Name = "WfTreat";
            activitybind2.Path = "triageCompletedEventArgs";
            workflowparameterbinding2.ParameterName = "e";
            workflowparameterbinding2.SetBinding(System.Workflow.ComponentModel.WorkflowParameterBinding.ValueProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            this.接收分诊结果.ParameterBindings.Add(workflowparameterbinding2);
            // 
            // setStateActivity1
            // 
            this.setStateActivity1.Name = "setStateActivity1";
            this.setStateActivity1.TargetStateName = "分诊";
            // 
            // 等待就诊完成
            // 
            this.等待就诊完成.Activities.Add(this.接收就诊结果);
            this.等待就诊完成.Activities.Add(this.通知主工作流结束);
            this.等待就诊完成.Name = "等待就诊完成";
            // 
            // 等待分诊结果
            // 
            this.等待分诊结果.Activities.Add(this.接收分诊结果);
            this.等待分诊结果.Activities.Add(this.分诊分支);
            this.等待分诊结果.Activities.Add(this.setStateActivity2);
            this.等待分诊结果.Name = "等待分诊结果";
            // 
            // 初始化
            // 
            this.初始化.Activities.Add(this.setStateActivity1);
            this.初始化.Name = "初始化";
            // 
            // 就诊
            // 
            this.就诊.Activities.Add(this.等待就诊完成);
            this.就诊.Name = "就诊";
            // 
            // 分诊
            // 
            this.分诊.Activities.Add(this.等待分诊结果);
            this.分诊.Name = "分诊";
            // 
            // 初始状态
            // 
            this.初始状态.Activities.Add(this.初始化);
            this.初始状态.Name = "初始状态";
            // 
            // WfTreat
            // 
            this.Activities.Add(this.初始状态);
            this.Activities.Add(this.分诊);
            this.Activities.Add(this.就诊);
            this.CompletedStateName = null;
            this.DynamicUpdateCondition = null;
            this.InitialStateName = "初始状态";
            this.Name = "WfTreat";
            this.CanModifyActivities = false;

        }

        #endregion

        private CodeActivity 通知主工作流结束;
        private SetStateActivity setStateActivity1;
        private StateInitializationActivity 初始化;
        private HandleExternalEventActivity 接收分诊结果;
        private EventDrivenActivity 等待分诊结果;
        private StateActivity 分诊;
        private IfElseBranchActivity 分诊至其他;
        private IfElseBranchActivity 分诊至肠胃科;
        private IfElseActivity 分诊分支;
        private EventDrivenActivity 等待就诊完成;
        private StateActivity 就诊;
        private SetStateActivity setStateActivity2;
        private HandleExternalEventActivity 接收就诊结果;
        private StateActivity 初始状态;






















































































































































































































































    }
}
