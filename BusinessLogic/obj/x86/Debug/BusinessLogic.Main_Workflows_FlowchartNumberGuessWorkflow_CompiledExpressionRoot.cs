namespace BusinessLogic.Main_Workflows {
    
    #line 23 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 28 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using BusinessObject.DtoModels;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Main Workflows\FlowchartNumberGuessWorkflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class FlowchartNumberGuessWorkflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext1 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext2 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext3 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext4 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext4.GetLocation<BusinessObject.DtoModels.Game>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext5 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext6 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext7 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext8 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext9 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext10 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext11 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext12 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext12.GetLocation<BusinessObject.DtoModels.Game>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext13 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext13.GetLocation<BusinessObject.DtoModels.Game>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext14 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext15 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext16 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext17 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext18 = ((FlowchartNumberGuessWorkflow_TypedDataContext2)(cachedCompiledDataContext[1]));
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext19 = ((FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext19.ValueType___Expr19Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext0 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext1 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext2 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext3 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext4 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<BusinessObject.DtoModels.Game>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext5 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext6 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<int>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext7 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            if ((expressionId == 8)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext8 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext9 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext10 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext10.ValueType___Expr10Get();
            }
            if ((expressionId == 11)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext11 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext12 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<BusinessObject.DtoModels.Game>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext13 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<BusinessObject.DtoModels.Game>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext14 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext15 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<string>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext16 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext17 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2 refDataContext18 = new FlowchartNumberGuessWorkflow_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly valDataContext19 = new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "null") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new System.Random().Next(1, MaxNumber + 1)") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Target") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Please enter a number between 1 and \" + MaxNumber") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Game") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Turns + 1") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Turns") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess == Target") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Guess < Target") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"new Game()
            {
                Id = Game.Id,
                Guess = Game.Guess,
                InstanceId = Game.InstanceId,
                MaxNumber = Game.MaxNumber,
                Result = Text,
                Turns = Turns,
                WorkflowType = Game.WorkflowType
            }") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Game") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Game") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Game") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"On point! You\'ve guessed \" + Guess + \" right \\nNumber of times \" + Turns") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Text") 
                        && (FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext1 : FlowchartNumberGuessWorkflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Turns;
            
            protected int MaxNumber;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Turns = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.MaxNumber = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((0 + locationsOffset), this.Turns);
                this.SetVariableValue((1 + locationsOffset), this.MaxNumber);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Turns") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MaxNumber") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return FlowchartNumberGuessWorkflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly : FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Turns;
            
            protected int MaxNumber;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            protected override void GetValueTypeValues() {
                this.Turns = ((int)(this.GetVariableValue((0 + locationsOffset))));
                this.MaxNumber = ((int)(this.GetVariableValue((1 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "Turns") 
                            || (locationReferences[(offset + 0)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "MaxNumber") 
                            || (locationReferences[(offset + 1)].Type != typeof(int)))) {
                    return false;
                }
                return FlowchartNumberGuessWorkflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext2 : FlowchartNumberGuessWorkflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Guess;
            
            protected int Target;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BusinessObject.DtoModels.Game Game {
                get {
                    return ((BusinessObject.DtoModels.Game)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string Text {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string variable1 {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 71 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 71 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
              Target;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 71 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
              Target = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 85 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
                  Game;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr4Get() {
                
                #line 85 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                  Game;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(BusinessObject.DtoModels.Game value) {
                
                #line 85 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                  Game = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(BusinessObject.DtoModels.Game value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 99 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      Turns;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr6Get() {
                
                #line 99 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                      Turns;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(int value) {
                
                #line 99 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                      Turns = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 218 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 218 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                  Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 218 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                                  Text = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 139 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
                                      Game;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr12Get() {
                
                #line 139 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                      Game;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(BusinessObject.DtoModels.Game value) {
                
                #line 139 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                                      Game = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(BusinessObject.DtoModels.Game value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 167 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
                                          Game;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr13Get() {
                
                #line 167 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                          Game;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(BusinessObject.DtoModels.Game value) {
                
                #line 167 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                                          Game = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(BusinessObject.DtoModels.Game value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 192 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 192 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                  Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(string value) {
                
                #line 192 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                                  Text = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 118 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 118 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                              Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(string value) {
                
                #line 118 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                
                              Text = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.Guess = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.Target = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((2 + locationsOffset), this.Guess);
                this.SetVariableValue((3 + locationsOffset), this.Target);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 4)].Name != "Game") 
                            || (locationReferences[(offset + 4)].Type != typeof(BusinessObject.DtoModels.Game)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Text") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "variable1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Guess") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Target") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return FlowchartNumberGuessWorkflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly : FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int Guess;
            
            protected int Target;
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public FlowchartNumberGuessWorkflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected BusinessObject.DtoModels.Game Game {
                get {
                    return ((BusinessObject.DtoModels.Game)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string Text {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string variable1 {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 60 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
          null;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr0Get() {
                
                #line 60 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
          null;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 76 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
              new System.Random().Next(1, MaxNumber + 1);
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr1Get() {
                
                #line 76 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
              new System.Random().Next(1, MaxNumber + 1);
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 90 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  "Please enter a number between 1 and " + MaxNumber;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 90 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                  "Please enter a number between 1 and " + MaxNumber;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 104 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      Turns + 1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 104 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                      Turns + 1;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 111 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Guess == Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr7Get() {
                
                #line 111 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                      Guess == Target;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 185 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                          Guess < Target;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr8Get() {
                
                #line 185 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                          Guess < Target;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 229 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 229 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                    Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 144 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
                                      new Game()
            {
                Id = Game.Id,
                Guess = Game.Guess,
                InstanceId = Game.InstanceId,
                MaxNumber = Game.MaxNumber,
                Result = Text,
                Turns = Turns,
                WorkflowType = Game.WorkflowType
            };
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr11Get() {
                
                #line 144 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                      new Game()
            {
                Id = Game.Id,
                Guess = Game.Guess,
                InstanceId = Game.InstanceId,
                MaxNumber = Game.MaxNumber,
                Result = Text,
                Turns = Turns,
                WorkflowType = Game.WorkflowType
            };
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 162 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
                                          Game;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr14Get() {
                
                #line 162 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                          Game;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 203 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                    Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 203 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                    Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 123 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                              "On point! You've guessed " + Guess + " right \nNumber of times " + Turns;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 123 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                              "On point! You've guessed " + Guess + " right \nNumber of times " + Turns;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 131 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr19Get() {
                
                #line 131 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\MAIN WORKFLOWS\FLOWCHARTNUMBERGUESSWORKFLOW.XAML"
                return 
                                Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            protected override void GetValueTypeValues() {
                this.Guess = ((int)(this.GetVariableValue((2 + locationsOffset))));
                this.Target = ((int)(this.GetVariableValue((3 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 7))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 7);
                }
                expectedLocationsCount = 7;
                if (((locationReferences[(offset + 4)].Name != "Game") 
                            || (locationReferences[(offset + 4)].Type != typeof(BusinessObject.DtoModels.Game)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "Text") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "variable1") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Guess") 
                            || (locationReferences[(offset + 2)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Target") 
                            || (locationReferences[(offset + 3)].Type != typeof(int)))) {
                    return false;
                }
                return FlowchartNumberGuessWorkflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
