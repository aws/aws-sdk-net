﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.SimpleWorkflow.Model;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ConstantClassTests
    {
        [TestMethod]
        [TestCategory("SimpleWorkflow")]
        public void ImplicitStringNullCheck()
        {
            // This tests a bug where the null casted as a string invoked the implicit conversion with the null which caused an exception.
            StartChildWorkflowExecutionDecisionAttributes test = new StartChildWorkflowExecutionDecisionAttributes()
            {
                ChildPolicy = (string)null
            };
        }
    }
}
