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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetApplicationRevisions operation.
    /// Gets information about one or more application revisions. The maximum number of application
    /// revisions that can be returned is 25.
    /// </summary>
    public partial class BatchGetApplicationRevisionsRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private List<RevisionLocation> _revisions = new List<RevisionLocation>();

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an AWS CodeDeploy application about which to get revision information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property Revisions. 
        /// <para>
        /// An array of <code>RevisionLocation</code> objects that specify information to get
        /// about the application revisions, including type and location. The maximum number of
        /// <code>RevisionLocation</code> objects you can specify is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RevisionLocation> Revisions
        {
            get { return this._revisions; }
            set { this._revisions = value; }
        }

        // Check to see if Revisions property is set
        internal bool IsSetRevisions()
        {
            return this._revisions != null && this._revisions.Count > 0; 
        }

    }
}