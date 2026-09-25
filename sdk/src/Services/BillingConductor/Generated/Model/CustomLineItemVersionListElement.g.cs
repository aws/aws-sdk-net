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
    /// A representation of a custom line item version.
    /// </summary>
    public partial class CustomLineItemVersionListElement
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account in which this custom line item will be applied to.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  A list of custom line item Amazon Resource Names (ARNs) to retrieve information.
        /// 
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
        /// The number of resources that are associated with the custom line item.
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
        /// The Amazon Resource Name (ARN) of the billing group that the custom line item applies
        /// to.
        /// </para>
        /// </summary>
        public string BillingGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the BillingGroupArn property is set.
        /// </summary>
        internal bool IsSetBillingGroupArn() => this.BillingGroupArn != null;

        /// <summary>
        /// Gets and sets the property ChargeDetails.
        /// </summary>
        public ListCustomLineItemChargeDetails ChargeDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChargeDetails property is set.
        /// </summary>
        internal bool IsSetChargeDetails() => this.ChargeDetails != null;

        /// <summary>
        /// Gets and sets the property ComputationRule. 
        /// <para>
        ///  The computation rule for a specific version of a custom line item, determining how
        /// charges are computed and reflected in the bill. 
        /// </para>
        /// </summary>
        public ComputationRuleEnum ComputationRule { get; set; }

        /// <summary>
        /// Checks to see if the ComputationRule property is set.
        /// </summary>
        internal bool IsSetComputationRule() => this.ComputationRule != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the custom line item version was created.
        /// </para>
        /// </summary>
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The charge value currency of the custom line item.
        /// </para>
        /// </summary>
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom line item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndBillingPeriod. 
        /// <para>
        /// The end billing period of the custom line item version.
        /// </para>
        /// </summary>
        public string EndBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the EndBillingPeriod property is set.
        /// </summary>
        internal bool IsSetEndBillingPeriod() => this.EndBillingPeriod != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The most recent time that the custom line item version was modified.
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
        /// The name of the custom line item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PresentationDetails. 
        /// <para>
        ///  Presentation configuration for a specific version of a custom line item, specifying
        /// how charges are displayed in the bill. 
        /// </para>
        /// </summary>
        public PresentationObject PresentationDetails { get; set; }

        /// <summary>
        /// Checks to see if the PresentationDetails property is set.
        /// </summary>
        internal bool IsSetPresentationDetails() => this.PresentationDetails != null;

        /// <summary>
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The product code that’s associated with the custom line item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 29)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Checks to see if the ProductCode property is set.
        /// </summary>
        internal bool IsSetProductCode() => this.ProductCode != null;

        /// <summary>
        /// Gets and sets the property StartBillingPeriod. 
        /// <para>
        /// The start billing period of the custom line item version.
        /// </para>
        /// </summary>
        public string StartBillingPeriod { get; set; }

        /// <summary>
        /// Checks to see if the StartBillingPeriod property is set.
        /// </summary>
        internal bool IsSetStartBillingPeriod() => this.StartBillingPeriod != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The inclusive start time. 
        /// </para>
        /// </summary>
        public long? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
