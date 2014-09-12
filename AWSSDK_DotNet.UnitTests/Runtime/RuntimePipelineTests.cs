using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RuntimePipelineTests
    {
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AddHandlerTest()
        {
            var handlerA = new TestHandlerA();
            var pipeline = new RuntimePipeline(handlerA);
            var handlerB = new TestHandlerB();
            // B->A
            pipeline.AddHandler(handlerB);

            ValidatePipeline(pipeline, handlerB, handlerA);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AddHandlerAfterTest()
        {
            var handlerC = new TestHandlerC();
            var pipeline = new RuntimePipeline(handlerC);
            var handlerA = new TestHandlerA();
            // A->C
            pipeline.AddHandler(handlerA);
            var handlerB = new TestHandlerB();
            // A->B->C
            pipeline.AddHandlerAfter<TestHandlerA>(handlerB);
            ValidatePipeline(pipeline, handlerA, handlerB, handlerC);

            var handlerD = new TestHandlerD();
            // A->B->C->D
            pipeline.AddHandlerAfter<TestHandlerC>(handlerD);
            ValidatePipeline(pipeline, handlerA, handlerB, handlerC, handlerD);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AddHandlerBeforeTest()
        {
            var handlerD = new TestHandlerD();
            var pipeline = new RuntimePipeline(handlerD);
            var handlerB = new TestHandlerB();
            // B->D
            pipeline.AddHandler(handlerB);
            var handlerA = new TestHandlerA();
            // A->B->D
            pipeline.AddHandlerBefore<TestHandlerB>(handlerA);
            ValidatePipeline(pipeline, handlerA, handlerB, handlerD);

            var handlerC = new TestHandlerC();
            // A->B->C->D
            pipeline.AddHandlerBefore<TestHandlerD>(handlerC);
            ValidatePipeline(pipeline, handlerA, handlerB, handlerC, handlerD);            
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ReplaceHandlerTest()
        {
            var handlerC = new TestHandlerC();
            var pipeline = new RuntimePipeline(handlerC);
            var handlerB = new TestHandlerB();            
            pipeline.AddHandler(handlerB);
            var handlerA = new TestHandlerA();
            //A->B->C
            pipeline.AddHandler(handlerA);
            ValidatePipeline(pipeline, handlerA, handlerB, handlerC);

            var handlerD = new TestHandlerD();
            //A->D->C
            pipeline.ReplaceHandler<TestHandlerB>(handlerD);
            ValidatePipeline(pipeline, handlerA, handlerD, handlerC);
            Assert.IsNull(handlerB.OuterHandler);
            Assert.IsNull(handlerB.InnerHandler);
        }

        void ValidatePipeline(RuntimePipeline pipeline,params IPipelineHandler[] handlers)
        {
            Assert.AreEqual(pipeline.Handler, handlers[0]);
            for (int index = 0; index < handlers.Length; index++)
            {
                if (index>0)
                {
                    Assert.AreEqual(handlers[index - 1], handlers[index].OuterHandler);
                }
                if (index < handlers.Length - 1)
                {
                    Assert.AreEqual(handlers[index + 1], handlers[index].InnerHandler);
                }
            }
        }
    }

    public class TestHandlerA : PipelineHandler { }

    public class TestHandlerB : PipelineHandler { }

    public class TestHandlerC : PipelineHandler { }

    public class TestHandlerD : PipelineHandler { }

}
