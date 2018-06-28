namespace BusinessLogic.Sub_Workflows {
    
    #line 22 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 23 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 24 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 25 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 26 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 27 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using BusinessObject.DtoModels;
    
    #line default
    #line hidden
    
    #line 1 "C:\Users\MosesShilenge\Documents\Visual Studio 2013\Projects\WorkflowNTier\Workflow\BusinessLogic\Sub Workflows\Prompt.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Prompt : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
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
                this.dataContextActivities = Prompt_TypedDataContext1_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Prompt_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Prompt_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Prompt_TypedDataContext1_ForReadOnly valDataContext0 = ((Prompt_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Prompt_TypedDataContext1.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Prompt_TypedDataContext1(locations, activityContext, true);
                }
                Prompt_TypedDataContext1 refDataContext1 = ((Prompt_TypedDataContext1)(cachedCompiledDataContext[1]));
                return refDataContext1.GetLocation<BusinessObject.DtoModels.Game>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Prompt_TypedDataContext1_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Prompt_TypedDataContext1_ForReadOnly(locations, activityContext, true);
                }
                Prompt_TypedDataContext1_ForReadOnly valDataContext2 = ((Prompt_TypedDataContext1_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext2.ValueType___Expr2Get();
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
                Prompt_TypedDataContext1_ForReadOnly valDataContext0 = new Prompt_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Prompt_TypedDataContext1 refDataContext1 = new Prompt_TypedDataContext1(locations, true);
                return refDataContext1.GetLocation<BusinessObject.DtoModels.Game>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Prompt_TypedDataContext1_ForReadOnly valDataContext2 = new Prompt_TypedDataContext1_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "BookmarkName") 
                        && (Prompt_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Result") 
                        && (Prompt_TypedDataContext1.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Text") 
                        && (Prompt_TypedDataContext1_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
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
                return new Prompt_TypedDataContext1_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Prompt_TypedDataContext1(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Prompt_TypedDataContext1_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Prompt_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Prompt_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Prompt_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Prompt_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
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
        private class Prompt_TypedDataContext1 : Prompt_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Prompt_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string BookmarkName {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string Text {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected BusinessObject.DtoModels.Game Result {
                get {
                    return ((BusinessObject.DtoModels.Game)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 62 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                System.Linq.Expressions.Expression<System.Func<BusinessObject.DtoModels.Game>> expression = () => 
          Result;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public BusinessObject.DtoModels.Game @__Expr1Get() {
                
                #line 62 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                return 
          Result;
                
                #line default
                #line hidden
            }
            
            public BusinessObject.DtoModels.Game ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(BusinessObject.DtoModels.Game value) {
                
                #line 62 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                
          Result = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(BusinessObject.DtoModels.Game value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "BookmarkName") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Text") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Result") 
                            || (locationReferences[(offset + 2)].Type != typeof(BusinessObject.DtoModels.Game)))) {
                    return false;
                }
                return Prompt_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Prompt_TypedDataContext1_ForReadOnly : Prompt_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Prompt_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Prompt_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string BookmarkName {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string Text {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected BusinessObject.DtoModels.Game Result {
                get {
                    return ((BusinessObject.DtoModels.Game)(this.GetVariableValue((2 + locationsOffset))));
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
                
                #line 57 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          BookmarkName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 57 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                return 
          BookmarkName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 68 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
        Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 68 "C:\USERS\MOSESSHILENGE\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\WORKFLOWNTIER\WORKFLOW\BUSINESSLOGIC\SUB WORKFLOWS\PROMPT.XAML"
                return 
        Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "BookmarkName") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "Text") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Result") 
                            || (locationReferences[(offset + 2)].Type != typeof(BusinessObject.DtoModels.Game)))) {
                    return false;
                }
                return Prompt_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
