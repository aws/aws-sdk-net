/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.RDS;
using Amazon.RDS.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class RDSConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void AuthorizeDBSecurityGroupIngressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.AuthorizeDBSecurityGroupIngressRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void CreateDBInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.CreateDBInstanceRequest), new System.Type[] { typeof(string), typeof(int), typeof(string), typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void CreateDBInstanceReadReplicaRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.CreateDBInstanceReadReplicaRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void CreateDBParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.CreateDBParameterGroupRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void CreateDBSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.CreateDBSecurityGroupRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void CreateDBSnapshotRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.CreateDBSnapshotRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DeleteDBInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DeleteDBInstanceRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DeleteDBParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DeleteDBParameterGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DeleteDBSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DeleteDBSecurityGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DeleteDBSnapshotRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DeleteDBSnapshotRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBEngineVersionsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBInstancesRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBParameterGroupsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBParametersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DescribeDBParametersRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBSecurityGroupsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeDBSnapshotsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeEngineDefaultParametersRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.DescribeEngineDefaultParametersRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeEventsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeReservedDBInstancesRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void DescribeReservedDBInstancesOfferingsRequestConstructorTests()
        {
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void ModifyDBInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.ModifyDBInstanceRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void ModifyDBParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.ModifyDBParameterGroupRequest), new System.Type[] { typeof(string), typeof(List<Parameter>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void PurchaseReservedDBInstancesOfferingRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.PurchaseReservedDBInstancesOfferingRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void RebootDBInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.RebootDBInstanceRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void ResetDBParameterGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.ResetDBParameterGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void RestoreDBInstanceFromDBSnapshotRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.RestoreDBInstanceFromDBSnapshotRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void RestoreDBInstanceToPointInTimeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.RestoreDBInstanceToPointInTimeRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("RDS")]
        public void RevokeDBSecurityGroupIngressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.RDS.Model.RevokeDBSecurityGroupIngressRequest), new System.Type[] { typeof(string), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}