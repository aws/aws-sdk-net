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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Identifies an Amazon EC2 launch template to use for a specific account.
    /// </summary>
    public partial class LaunchTemplateConfiguration
    {
        private string _accountId;
        private string _launchTemplateId;
        private bool? _setDefaultVersion;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that this configuration applies to.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// Identifies the Amazon EC2 launch template to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LaunchTemplateId
        {
            get { return this._launchTemplateId; }
            set { this._launchTemplateId = value; }
        }

        // Check to see if LaunchTemplateId property is set
        internal bool IsSetLaunchTemplateId()
        {
            return this._launchTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property SetDefaultVersion. 
        /// <para>
        /// Set the specified Amazon EC2 launch template as the default launch template for the
        /// specified account.
        /// </para>
        /// </summary>
        public bool? SetDefaultVersion
        {
            get { return this._setDefaultVersion; }
            set { this._setDefaultVersion = value; }
        }

        // Check to see if SetDefaultVersion property is set
        internal bool IsSetSetDefaultVersion()
        {
            return this._setDefaultVersion.HasValue; 
        }

    }
}