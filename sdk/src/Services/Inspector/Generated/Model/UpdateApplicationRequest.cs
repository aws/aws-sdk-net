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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates application specified by the application ARN.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonInspectorRequest
    {
        private string _applicationArn;
        private string _applicationName;
        private string _resourceGroupArn;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// Application ARN that you want to update.
        /// </para>
        /// </summary>
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Application name that you want to update.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceGroupArn. 
        /// <para>
        /// The resource group ARN that you want to update.
        /// </para>
        /// </summary>
        public string ResourceGroupArn
        {
            get { return this._resourceGroupArn; }
            set { this._resourceGroupArn = value; }
        }

        // Check to see if ResourceGroupArn property is set
        internal bool IsSetResourceGroupArn()
        {
            return this._resourceGroupArn != null;
        }

    }
}