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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the information about an entity recognizer and its versions.
    /// </summary>
    public partial class EntityRecognizerSummary
    {
        /// <summary>
        /// Gets and sets the property LatestVersionCreatedAt. 
        /// <para>
        ///  The time that the latest entity recognizer version was submitted for processing.
        /// </para>
        /// </summary>
        public DateTime? LatestVersionCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionCreatedAt property is set.
        /// </summary>
        internal bool IsSetLatestVersionCreatedAt() => this.LatestVersionCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersionName. 
        /// <para>
        ///  The version name you assigned to the latest entity recognizer version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string LatestVersionName { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionName property is set.
        /// </summary>
        internal bool IsSetLatestVersionName() => this.LatestVersionName != null;

        /// <summary>
        /// Gets and sets the property LatestVersionStatus. 
        /// <para>
        ///  Provides the status of the latest entity recognizer version.
        /// </para>
        /// </summary>
        public ModelStatus LatestVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionStatus property is set.
        /// </summary>
        internal bool IsSetLatestVersionStatus() => this.LatestVersionStatus != null;

        /// <summary>
        /// Gets and sets the property NumberOfVersions. 
        /// <para>
        ///  The number of versions you created.
        /// </para>
        /// </summary>
        public int? NumberOfVersions { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfVersions property is set.
        /// </summary>
        internal bool IsSetNumberOfVersions() => this.NumberOfVersions.HasValue;

        /// <summary>
        /// Gets and sets the property RecognizerName. 
        /// <para>
        ///  The name that you assigned the entity recognizer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string RecognizerName { get; set; }

        /// <summary>
        /// Checks to see if the RecognizerName property is set.
        /// </summary>
        internal bool IsSetRecognizerName() => this.RecognizerName != null;
    }
}
