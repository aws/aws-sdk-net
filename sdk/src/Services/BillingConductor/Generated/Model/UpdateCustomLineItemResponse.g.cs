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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the UpdateCustomLineItem operation.
    /// </summary>
    public partial class UpdateCustomLineItemResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the successfully updated custom line item. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssociationSize. 
        /// <para>
        ///  The number of resources that are associated to the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? AssociationSize { get; set; }

        /// <summary>
        /// Checks to see if the AssociationSize property is set.
        /// </summary>
        internal bool IsSetAssociationSize() => this.AssociationSize.HasValue;

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        ///  The ARN of the billing group that the custom line item is applied to. 
        /// </para>
        /// </summary>
        public string BillingGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupArn property is set.
        /// </summary>
        internal bool IsSetBillingGroupArn() => this.BillingGroupArn != null;

        /// <summary>
        /// Gets and sets the property ChargeDetails. 
        /// <para>
        ///  A <c>ListCustomLineItemChargeDetails</c> containing the charge details of the successfully
        /// updated custom line item. 
        /// </para>
        /// </summary>
        public ListCustomLineItemChargeDetails ChargeDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChargeDetails property is set.
        /// </summary>
        internal bool IsSetChargeDetails() => this.ChargeDetails != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the successfully updated custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        ///  The most recent time when the custom line item was modified. 
        /// </para>
        /// </summary>
        public long? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the successfully updated custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
