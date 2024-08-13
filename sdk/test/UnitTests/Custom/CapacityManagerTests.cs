/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class CapacityManagerTests
    {
        RetryCapacity retryCapacity;
    
        /// <summary>
        /// This Unit test verifies the behavior of the capacity manager when the request is a valid retry request with 
        /// sufficient capacity available.
        /// </summary>
        [TestMethod]
        [TestCategory("CapacityManagerUnitTest")]
        [TestCategory("Runtime")]
        public void AcquireCapacityUnitTest()
        {
            int throttleRetryCount = 5; 
            int throttleRetryCost = 5; 
            int throttleCost = 1;
            CapacityManager capacityManagerInstance = new CapacityManager(throttleRetryCount, throttleRetryCost, throttleCost);
            retryCapacity = capacityManagerInstance.GetRetryCapacity("AcquireCapacityUnitTest");
            Assert.IsNotNull(retryCapacity);
            Assert.IsTrue(capacityManagerInstance.TryAcquireCapacity(retryCapacity));
            Assert.AreEqual(throttleRetryCost*(throttleRetryCount-1), retryCapacity.AvailableCapacity);
            var consumedCapacity = retryCapacity.MaxCapacity - retryCapacity.AvailableCapacity;
            Assert.AreEqual(throttleRetryCost, consumedCapacity);
        }

        
        /// <summary>
        /// This Unit test verifies the behavior of the capacity manager when the request is a valid retry request but 
        /// insufficient capacity available.
        /// </summary>
        [TestMethod]
        [TestCategory("CapacityManagerUnitTest")]
        [TestCategory("Runtime")]
        public void AcquireCapacityInvalidUnitTest()
        {
            int throttleRetryCount = 0;
            int throttleRetryCost = 5;
            int throttleCost = 1;
            CapacityManager capacityManagerInstance = new CapacityManager(throttleRetryCount, throttleRetryCost, throttleCost);
            retryCapacity = capacityManagerInstance.GetRetryCapacity("AcquireCapacityInvalidUnitTest");
            Assert.IsNotNull(retryCapacity);
            Assert.IsFalse(capacityManagerInstance.TryAcquireCapacity(retryCapacity));
            Assert.AreEqual(0, retryCapacity.AvailableCapacity);
            var consumedCapacity = retryCapacity.MaxCapacity - retryCapacity.AvailableCapacity;
            Assert.AreEqual(0, consumedCapacity);
        }


        /// <summary>
        /// This Unit test verifies the behavior of the capacity manager when capacity is released back.
        /// This test runs for both successful retry and non-retry requests
        /// </summary>
        [TestMethod]
        [TestCategory("CapacityManagerUnitTest")]
        [TestCategory("Runtime")]
        public void ReleaseCapacityUnitTest()
        {
            int throttleRetryCount = 5;
            int throttleRetryCost = 5;
            int throttleCost = 1;
            CapacityManager capacityManagerInstance = new CapacityManager(throttleRetryCount, throttleRetryCost, throttleCost);
            retryCapacity = capacityManagerInstance.GetRetryCapacity("ReleaseCapacityUnitTest");
            Assert.IsNotNull(retryCapacity);
            Assert.IsTrue(capacityManagerInstance.TryAcquireCapacity(retryCapacity));

            capacityManagerInstance.ReleaseCapacity(CapacityManager.CapacityType.Retry, retryCapacity);
            Assert.AreEqual(throttleRetryCost * throttleRetryCount, retryCapacity.AvailableCapacity);
            var consumedCapacity = retryCapacity.MaxCapacity - retryCapacity.AvailableCapacity;
            Assert.AreEqual(0, consumedCapacity);

            capacityManagerInstance.ReleaseCapacity(CapacityManager.CapacityType.Increment, retryCapacity);
            Assert.AreEqual(throttleRetryCost * throttleRetryCount, retryCapacity.AvailableCapacity);
            consumedCapacity = retryCapacity.MaxCapacity - retryCapacity.AvailableCapacity;
            Assert.AreEqual(0, consumedCapacity);
        }

        
        /// <summary>
        /// This Unit test verifies the behavior of the capacity manager when capacity is released back
        /// but the capacity is already at the maximum allowed value.
        /// </summary>
        [TestMethod]
        [TestCategory("CapacityManagerUnitTest")]
        [TestCategory("Runtime")]
        public void ReleaseCapacityInvalidUnitTest()
        {
            int throttleRetryCount = 5;
            int throttleRetryCost = 5;
            int throttleCost = 1;
            CapacityManager capacityManagerInstance = new CapacityManager(throttleRetryCount, throttleRetryCost, throttleCost);
            retryCapacity = capacityManagerInstance.GetRetryCapacity("ReleaseCapacityInvalidUnitTest");
            Assert.IsNotNull(retryCapacity);

            capacityManagerInstance.ReleaseCapacity(CapacityManager.CapacityType.Increment, retryCapacity);
            Assert.AreEqual(throttleRetryCost * throttleRetryCount, retryCapacity.AvailableCapacity);
            var consumedCapacity = retryCapacity.MaxCapacity - retryCapacity.AvailableCapacity;
            Assert.AreEqual(0, consumedCapacity);
        }
    }
}
