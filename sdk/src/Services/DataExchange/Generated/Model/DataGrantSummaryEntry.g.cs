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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Information about a data grant.
    /// </summary>
    public partial class DataGrantSummaryEntry
    {
        /// <summary>
        /// Gets and sets the property AcceptanceState. 
        /// <para>
        /// The acceptance state of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataGrantAcceptanceState AcceptanceState { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceState property is set.
        /// </summary>
        internal bool IsSetAcceptanceState() => this.AcceptanceState != null;

        /// <summary>
        /// Gets and sets the property AcceptedAt. 
        /// <para>
        /// The timestamp of when the data grant was accepted.
        /// </para>
        /// </summary>
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// Checks to see if the AcceptedAt property is set.
        /// </summary>
        internal bool IsSetAcceptedAt() => this.AcceptedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the data grant was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the data set associated to the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property EndsAt. 
        /// <para>
        /// The timestamp of when access to the associated data set ends.
        /// </para>
        /// </summary>
        public DateTime? EndsAt { get; set; }

        /// <summary>
        /// Checks to see if the EndsAt property is set.
        /// </summary>
        internal bool IsSetEndsAt() => this.EndsAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReceiverPrincipal. 
        /// <para>
        /// The Amazon Web Services account ID of the data grant receiver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReceiverPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ReceiverPrincipal property is set.
        /// </summary>
        internal bool IsSetReceiverPrincipal() => this.ReceiverPrincipal != null;

        /// <summary>
        /// Gets and sets the property SenderPrincipal. 
        /// <para>
        /// The Amazon Web Services account ID of the data grant sender.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SenderPrincipal { get; set; }

        /// <summary>
        /// Checks to see if the SenderPrincipal property is set.
        /// </summary>
        internal bool IsSetSenderPrincipal() => this.SenderPrincipal != null;

        /// <summary>
        /// Gets and sets the property SourceDataSetId. 
        /// <para>
        /// The ID of the data set used to create the data grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceDataSetId { get; set; }

        /// <summary>
        /// Checks to see if the SourceDataSetId property is set.
        /// </summary>
        internal bool IsSetSourceDataSetId() => this.SourceDataSetId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the data grant was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
