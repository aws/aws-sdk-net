/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Describes the Spot Datafeed subscription.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class SpotDatafeedSubscription
    {    
        private string ownerIdField;
        private string bucketField;
        private string prefixField;
        private string stateField;
        private SpotInstanceStateFault faultField;

        /// <summary>
        /// Gets and sets the OwnerId property.
        /// The AWS account ID associated with the
        /// subscription.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the OwnerId property
        /// </summary>
        /// <param name="ownerId">The AWS account ID associated with the
        /// subscription.</param>
        /// <returns>this instance</returns>
        public SpotDatafeedSubscription WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// Gets and sets the Bucket property.
        /// The Amazon S3 bucket where the Spot Instance
        /// datafeed is located.
        /// </summary>
        [XmlElementAttribute(ElementName = "Bucket")]
        public string Bucket
        {
            get { return this.bucketField; }
            set { this.bucketField = value; }
        }

        /// <summary>
        /// Sets the Bucket property
        /// </summary>
        /// <param name="bucket">The Amazon S3 bucket where the Spot Instance
        /// datafeed is located.</param>
        /// <returns>this instance</returns>
        public SpotDatafeedSubscription WithBucket(string bucket)
        {
            this.bucketField = bucket;
            return this;
        }

        /// <summary>
        /// Checks if Bucket property is set
        /// </summary>
        /// <returns>true if Bucket property is set</returns>
        public bool IsSetBucket()
        {
            return this.bucketField != null;
        }

        /// <summary>
        /// Gets and sets the Prefix property.
        /// The Prefix prepended to the datafeed files.
        /// </summary>
        [XmlElementAttribute(ElementName = "Prefix")]
        public string Prefix
        {
            get { return this.prefixField; }
            set { this.prefixField = value; }
        }

        /// <summary>
        /// Sets the Prefix property
        /// </summary>
        /// <param name="prefix">The Prefix prepended to the datafeed files.</param>
        /// <returns>this instance</returns>
        public SpotDatafeedSubscription WithPrefix(string prefix)
        {
            this.prefixField = prefix;
            return this;
        }

        /// <summary>
        /// Checks if Prefix property is set
        /// </summary>
        /// <returns>true if Prefix property is set</returns>
        public bool IsSetPrefix()
        {
            return this.prefixField != null;
        }

        /// <summary>
        /// Gets and sets the State property.
        /// The state of the Spot Instance request.
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The state of the Spot Instance request.</param>
        /// <returns>this instance</returns>
        public SpotDatafeedSubscription WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

        /// <summary>
        /// Gets and sets the Fault property.
        /// Fault details for the Spot Instance request, if
        /// any.
        /// </summary>
        [XmlElementAttribute(ElementName = "Fault")]
        public SpotInstanceStateFault Fault
        {
            get { return this.faultField; }
            set { this.faultField = value; }
        }

        /// <summary>
        /// Sets the Fault property
        /// </summary>
        /// <param name="fault">Fault details for the Spot Instance request, if
        /// any.</param>
        /// <returns>this instance</returns>
        public SpotDatafeedSubscription WithFault(SpotInstanceStateFault fault)
        {
            this.faultField = fault;
            return this;
        }

        /// <summary>
        /// Checks if Fault property is set
        /// </summary>
        /// <returns>true if Fault property is set</returns>
        public bool IsSetFault()
        {
            return this.faultField != null;
        }

    }
}
