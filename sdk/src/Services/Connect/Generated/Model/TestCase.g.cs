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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a test case.
    /// </summary>
    public partial class TestCase
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the test case.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON string that represents the content of the test.
        /// </para>
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the test case.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// Defines the starting point for the test, including channel type and parameters.
        /// </para>
        /// </summary>
        public TestCaseEntryPoint EntryPoint { get; set; }

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InitializationData. 
        /// <para>
        /// Defines the test attributes for precise data representation. The value must be a valid
        /// JSON string.
        /// </para>
        /// </summary>
        public string InitializationData { get; set; }

        /// <summary>
        /// Checks to see if the InitializationData property is set.
        /// </summary>
        internal bool IsSetInitializationData() => this.InitializationData != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The region in which the test case was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the test case was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the test case.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the test status as either SAVED or PUBLISHED.
        /// </para>
        /// </summary>
        public TestCaseStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TestCaseSha256. 
        /// <para>
        /// The SHA256 hash of the test case content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TestCaseSha256 { get; set; }

        /// <summary>
        /// Checks to see if the TestCaseSha256 property is set.
        /// </summary>
        internal bool IsSetTestCaseSha256() => this.TestCaseSha256 != null;
    }
}
