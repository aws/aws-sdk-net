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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the resource action summary.
    /// </summary>
    public partial class ResourceActionSummary
    {
        private CloudFormationStepSummary _cloudFormation;
        private M2ManagedApplicationStepSummary _m2ManagedApplication;
        private M2NonManagedApplicationStepSummary _m2NonManagedApplication;

        /// <summary>
        /// Gets and sets the property CloudFormation. 
        /// <para>
        /// The CloudFormation template of the resource action summary.
        /// </para>
        /// </summary>
        public CloudFormationStepSummary CloudFormation
        {
            get { return this._cloudFormation; }
            set { this._cloudFormation = value; }
        }

        // Check to see if CloudFormation property is set
        internal bool IsSetCloudFormation()
        {
            return this._cloudFormation != null;
        }

        /// <summary>
        /// Gets and sets the property M2ManagedApplication. 
        /// <para>
        /// The AWS Mainframe Modernization managed application of the resource action summary.
        /// </para>
        /// </summary>
        public M2ManagedApplicationStepSummary M2ManagedApplication
        {
            get { return this._m2ManagedApplication; }
            set { this._m2ManagedApplication = value; }
        }

        // Check to see if M2ManagedApplication property is set
        internal bool IsSetM2ManagedApplication()
        {
            return this._m2ManagedApplication != null;
        }

        /// <summary>
        /// Gets and sets the property M2NonManagedApplication. 
        /// <para>
        /// The AWS Mainframe Modernization non-managed application of the resource action summary.
        /// </para>
        /// </summary>
        public M2NonManagedApplicationStepSummary M2NonManagedApplication
        {
            get { return this._m2NonManagedApplication; }
            set { this._m2NonManagedApplication = value; }
        }

        // Check to see if M2NonManagedApplication property is set
        internal bool IsSetM2NonManagedApplication()
        {
            return this._m2NonManagedApplication != null;
        }

    }
}