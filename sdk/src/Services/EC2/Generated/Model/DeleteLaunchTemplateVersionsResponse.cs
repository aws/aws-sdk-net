/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DeleteLaunchTemplateVersions operation.
    /// </summary>
    public partial class DeleteLaunchTemplateVersionsResponse : AmazonWebServiceResponse
    {
        private List<DeleteLaunchTemplateVersionsResponseSuccessItem> _successfullyDeletedLaunchTemplateVersions = new List<DeleteLaunchTemplateVersionsResponseSuccessItem>();
        private List<DeleteLaunchTemplateVersionsResponseErrorItem> _unsuccessfullyDeletedLaunchTemplateVersions = new List<DeleteLaunchTemplateVersionsResponseErrorItem>();

        /// <summary>
        /// Gets and sets the property SuccessfullyDeletedLaunchTemplateVersions. 
        /// <para>
        /// Information about the launch template versions that were successfully deleted.
        /// </para>
        /// </summary>
        public List<DeleteLaunchTemplateVersionsResponseSuccessItem> SuccessfullyDeletedLaunchTemplateVersions
        {
            get { return this._successfullyDeletedLaunchTemplateVersions; }
            set { this._successfullyDeletedLaunchTemplateVersions = value; }
        }

        // Check to see if SuccessfullyDeletedLaunchTemplateVersions property is set
        internal bool IsSetSuccessfullyDeletedLaunchTemplateVersions()
        {
            return this._successfullyDeletedLaunchTemplateVersions != null && this._successfullyDeletedLaunchTemplateVersions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfullyDeletedLaunchTemplateVersions. 
        /// <para>
        /// Information about the launch template versions that could not be deleted.
        /// </para>
        /// </summary>
        public List<DeleteLaunchTemplateVersionsResponseErrorItem> UnsuccessfullyDeletedLaunchTemplateVersions
        {
            get { return this._unsuccessfullyDeletedLaunchTemplateVersions; }
            set { this._unsuccessfullyDeletedLaunchTemplateVersions = value; }
        }

        // Check to see if UnsuccessfullyDeletedLaunchTemplateVersions property is set
        internal bool IsSetUnsuccessfullyDeletedLaunchTemplateVersions()
        {
            return this._unsuccessfullyDeletedLaunchTemplateVersions != null && this._unsuccessfullyDeletedLaunchTemplateVersions.Count > 0; 
        }

    }
}