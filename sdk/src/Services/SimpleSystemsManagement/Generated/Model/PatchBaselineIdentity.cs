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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines the basic information about a patch baseline.
    /// </summary>
    public partial class PatchBaselineIdentity
    {
        private string _baselineDescription;
        private string _baselineId;
        private string _baselineName;
        private bool? _defaultBaseline;
        private OperatingSystem _operatingSystem;

        /// <summary>
        /// Gets and sets the property BaselineDescription. 
        /// <para>
        /// The description of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string BaselineDescription
        {
            get { return this._baselineDescription; }
            set { this._baselineDescription = value; }
        }

        // Check to see if BaselineDescription property is set
        internal bool IsSetBaselineDescription()
        {
            return this._baselineDescription != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=128)]
        public string BaselineId
        {
            get { return this._baselineId; }
            set { this._baselineId = value; }
        }

        // Check to see if BaselineId property is set
        internal bool IsSetBaselineId()
        {
            return this._baselineId != null;
        }

        /// <summary>
        /// Gets and sets the property BaselineName. 
        /// <para>
        /// The name of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string BaselineName
        {
            get { return this._baselineName; }
            set { this._baselineName = value; }
        }

        // Check to see if BaselineName property is set
        internal bool IsSetBaselineName()
        {
            return this._baselineName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultBaseline. 
        /// <para>
        /// Indicates whether this is the default baseline. Amazon Web Services Systems Manager
        /// supports creating multiple default patch baselines. For example, you can create a
        /// default patch baseline for each operating system.
        /// </para>
        /// </summary>
        public bool? DefaultBaseline
        {
            get { return this._defaultBaseline; }
            set { this._defaultBaseline = value; }
        }

        // Check to see if DefaultBaseline property is set
        internal bool IsSetDefaultBaseline()
        {
            return this._defaultBaseline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Defines the operating system the patch baseline applies to. The default value is <c>WINDOWS</c>.
        /// 
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

    }
}