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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTemplate operation.
    /// Deletes a template.
    /// 
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
    /// reports_test_template --version-number 2 </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
    /// —alias-name STAGING </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>aws quicksight delete-template —aws-account-id 111122223333 —template-id reports_test_template
    /// —alias-name ‘\$LATEST’ </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>aws quicksight delete-template --aws-account-id 111122223333 —-template-id
    /// reports_test_template</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If version number which is an optional field is not passed the template (including
    /// all the versions) is deleted by the API, if version number is provided, the specific
    /// template version is deleted by the API.
    /// </para>
    ///  
    /// <para>
    /// Users can explicitly describe the latest version of the template by passing <code>$LATEST</code>
    /// to the <code>alias-name</code> parameter. <code>$LATEST</code> is an internally supported
    /// alias, which points to the latest version of the template. 
    /// </para>
    /// </summary>
    public partial class DeleteTemplateRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _templateId;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the template you are deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// An ID for the template you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}