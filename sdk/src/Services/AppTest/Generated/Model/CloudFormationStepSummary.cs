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
    /// Specifies the CloudFormation step summary.
    /// </summary>
    public partial class CloudFormationStepSummary
    {
        private CreateCloudFormationSummary _createCloudformation;
        private DeleteCloudFormationSummary _deleteCloudformation;

        /// <summary>
        /// Gets and sets the property CreateCloudformation. 
        /// <para>
        /// Creates the CloudFormation summary of the step.
        /// </para>
        /// </summary>
        public CreateCloudFormationSummary CreateCloudformation
        {
            get { return this._createCloudformation; }
            set { this._createCloudformation = value; }
        }

        // Check to see if CreateCloudformation property is set
        internal bool IsSetCreateCloudformation()
        {
            return this._createCloudformation != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteCloudformation. 
        /// <para>
        /// Deletes the CloudFormation summary of the CloudFormation step summary.
        /// </para>
        /// </summary>
        public DeleteCloudFormationSummary DeleteCloudformation
        {
            get { return this._deleteCloudformation; }
            set { this._deleteCloudformation = value; }
        }

        // Check to see if DeleteCloudformation property is set
        internal bool IsSetDeleteCloudformation()
        {
            return this._deleteCloudformation != null;
        }

    }
}