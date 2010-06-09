/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    ///<summary>
    ///Information about the Amazon EC2 instance associated with the job flow.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class JobFlowInstancesDetail
    {
        private string masterInstanceTypeField;
        private string masterPublicDnsNameField;
        private string masterInstanceIdField;
        private string slaveInstanceTypeField;
        private Decimal? instanceCountField;
        private string ec2KeyNameField;
        private PlacementType placementField;
        private bool? keepJobFlowAliveWhenNoStepsField;

        /// <summary>
        /// Gets and sets the MasterInstanceType property.
        /// Amazon EC2 master node instance type.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterInstanceType")]
        public string MasterInstanceType
        {
            get { return this.masterInstanceTypeField ; }
            set { this.masterInstanceTypeField= value; }
        }

        /// <summary>
        /// Sets the MasterInstanceType property
        /// </summary>
        /// <param name="masterInstanceType">Amazon EC2 master node instance type.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithMasterInstanceType(string masterInstanceType)
        {
            this.masterInstanceTypeField = masterInstanceType;
            return this;
        }

        /// <summary>
        /// Checks if MasterInstanceType property is set
        /// </summary>
        /// <returns>true if MasterInstanceType property is set</returns>
        public bool IsSetMasterInstanceType()
        {
            return  this.masterInstanceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the MasterPublicDnsName property.
        /// DNS name of master node.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterPublicDnsName")]
        public string MasterPublicDnsName
        {
            get { return this.masterPublicDnsNameField ; }
            set { this.masterPublicDnsNameField= value; }
        }

        /// <summary>
        /// Sets the MasterPublicDnsName property
        /// </summary>
        /// <param name="masterPublicDnsName">DNS name of master node.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithMasterPublicDnsName(string masterPublicDnsName)
        {
            this.masterPublicDnsNameField = masterPublicDnsName;
            return this;
        }

        /// <summary>
        /// Checks if MasterPublicDnsName property is set
        /// </summary>
        /// <returns>true if MasterPublicDnsName property is set</returns>
        public bool IsSetMasterPublicDnsName()
        {
            return  this.masterPublicDnsNameField != null;
        }

        /// <summary>
        /// Gets and sets the MasterInstanceId property.
        /// ID that uniquely identifies the master node instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterInstanceId")]
        public string MasterInstanceId
        {
            get { return this.masterInstanceIdField ; }
            set { this.masterInstanceIdField= value; }
        }

        /// <summary>
        /// Sets the MasterInstanceId property
        /// </summary>
        /// <param name="masterInstanceId">ID that uniquely identifies the master node instance.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithMasterInstanceId(string masterInstanceId)
        {
            this.masterInstanceIdField = masterInstanceId;
            return this;
        }

        /// <summary>
        /// Checks if MasterInstanceId property is set
        /// </summary>
        /// <returns>true if MasterInstanceId property is set</returns>
        public bool IsSetMasterInstanceId()
        {
            return  this.masterInstanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the SlaveInstanceType property.
        /// Amazon EC2 slave node instance type.
        /// </summary>
        [XmlElementAttribute(ElementName = "SlaveInstanceType")]
        public string SlaveInstanceType
        {
            get { return this.slaveInstanceTypeField ; }
            set { this.slaveInstanceTypeField= value; }
        }

        /// <summary>
        /// Sets the SlaveInstanceType property
        /// </summary>
        /// <param name="slaveInstanceType">Amazon EC2 slave node instance type.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithSlaveInstanceType(string slaveInstanceType)
        {
            this.slaveInstanceTypeField = slaveInstanceType;
            return this;
        }

        /// <summary>
        /// Checks if SlaveInstanceType property is set
        /// </summary>
        /// <returns>true if SlaveInstanceType property is set</returns>
        public bool IsSetSlaveInstanceType()
        {
            return  this.slaveInstanceTypeField != null;
        }

        /// <summary>
        /// Gets and sets the InstanceCount property.
        /// Number of Amazon EC2 instances in the cluster. If the value is 1, one instance serves as the master and slave node.
        /// If the value is greater than one, one instance is the master node and the remainder are slave nodes.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public Decimal InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault() ; }
            set { this.instanceCountField= value; }
        }

        /// <summary>
        /// Sets the InstanceCount property
        /// </summary>
        /// <param name="instanceCount">Number of Amazon EC2 instances in the cluster. If the value is 1, one instance serves as the master and slave node.
        /// If the value is greater than one, one instance is the master node and the remainder are slave nodes.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithInstanceCount(Decimal instanceCount)
        {
            this.instanceCountField = instanceCount;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCount property is set
        /// </summary>
        /// <returns>true if InstanceCount property is set</returns>
        public bool IsSetInstanceCount()
        {
            return  this.instanceCountField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Ec2KeyName property.
        /// A KeyName maps to a public key-private key pair, which is required to launch the master node. The private key is used by SSH to
        /// authenticate the tunneling connection between the developer and the EC2 master node that was launched using the
        /// KeyName.
        /// </summary>
        [XmlElementAttribute(ElementName = "Ec2KeyName")]
        public string Ec2KeyName
        {
            get { return this.ec2KeyNameField ; }
            set { this.ec2KeyNameField= value; }
        }

        /// <summary>
        /// Sets the Ec2KeyName property
        /// </summary>
        /// <param name="ec2KeyName">A KeyName maps to a public key-private key pair, which is required to launch the master node. The private key is used by SSH to
        /// authenticate the tunneling connection between the developer and the EC2 master node that was launched using the
        /// KeyName.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithEc2KeyName(string ec2KeyName)
        {
            this.ec2KeyNameField = ec2KeyName;
            return this;
        }

        /// <summary>
        /// Checks if Ec2KeyName property is set
        /// </summary>
        /// <returns>true if Ec2KeyName property is set</returns>
        public bool IsSetEc2KeyName()
        {
            return  this.ec2KeyNameField != null;
        }

        /// <summary>
        /// Gets and sets the Placement property.
        /// Container for PlacementType.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public PlacementType Placement
        {
            get { return this.placementField ; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the Placement property
        /// </summary>
        /// <param name="placement">Container for PlacementType.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithPlacement(PlacementType placement)
        {
            this.placementField = placement;
            return this;
        }

        /// <summary>
        /// Checks if Placement property is set
        /// </summary>
        /// <returns>true if Placement property is set</returns>
        public bool IsSetPlacement()
        {
            return this.placementField != null;
        }

        /// <summary>
        /// Gets and sets the KeepJobFlowAliveWhenNoSteps property.
        /// Specifies whether (true) or not (false) to keep the EC2 cluster engaged after all steps in the job flow complete.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeepJobFlowAliveWhenNoSteps")]
        public bool KeepJobFlowAliveWhenNoSteps
        {
            get { return this.keepJobFlowAliveWhenNoStepsField.GetValueOrDefault() ; }
            set { this.keepJobFlowAliveWhenNoStepsField= value; }
        }

        /// <summary>
        /// Sets the KeepJobFlowAliveWhenNoSteps property
        /// </summary>
        /// <param name="keepJobFlowAliveWhenNoSteps">Specifies whether (true) or not (false) to keep the EC2 cluster engaged after all steps in the job flow complete.</param>
        /// <returns>this instance</returns>
        public JobFlowInstancesDetail WithKeepJobFlowAliveWhenNoSteps(bool keepJobFlowAliveWhenNoSteps)
        {
            this.keepJobFlowAliveWhenNoStepsField = keepJobFlowAliveWhenNoSteps;
            return this;
        }

        /// <summary>
        /// Checks if KeepJobFlowAliveWhenNoSteps property is set
        /// </summary>
        /// <returns>true if KeepJobFlowAliveWhenNoSteps property is set</returns>
        public bool IsSetKeepJobFlowAliveWhenNoSteps()
        {
            return  this.keepJobFlowAliveWhenNoStepsField.HasValue;
        }

    }
}
