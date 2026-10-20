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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains summary information about the test set.
    /// </summary>
    public partial class TestSetSummary
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time at which the test set was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the test set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time at which the test set was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Modality. 
        /// <para>
        /// Specifies whether the test set contains written or spoken data.
        /// </para>
        /// </summary>
        public TestSetModality Modality { get; set; }

        /// <summary>
        /// Checks to see if the Modality property is set.
        /// </summary>
        internal bool IsSetModality() => this.Modality != null;

        /// <summary>
        /// Gets and sets the property NumTurns. 
        /// <para>
        /// The number of turns in the test set.
        /// </para>
        /// </summary>
        public int? NumTurns { get; set; }

        /// <summary>
        /// Checks to see if the NumTurns property is set.
        /// </summary>
        internal bool IsSetNumTurns() => this.NumTurns.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that has permission to access the test
        /// set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the test set.
        /// </para>
        /// </summary>
        public TestSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Contains information about the location at which the test set is stored.
        /// </para>
        /// </summary>
        public TestSetStorageLocation StorageLocation { get; set; }

        /// <summary>
        /// Checks to see if the StorageLocation property is set.
        /// </summary>
        internal bool IsSetStorageLocation() => this.StorageLocation != null;

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The unique identifier of the test set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestSetId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetId property is set.
        /// </summary>
        internal bool IsSetTestSetId() => this.TestSetId != null;

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The name of the test set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TestSetName { get; set; }

        /// <summary>
        /// Checks to see if the TestSetName property is set.
        /// </summary>
        internal bool IsSetTestSetName() => this.TestSetName != null;
    }
}
