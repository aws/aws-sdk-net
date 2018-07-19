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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRetentionConfiguration operation.
    /// Deletes the retention configuration.
    /// </summary>
    public partial class DeleteRetentionConfigurationRequest : AmazonConfigServiceRequest
    {
        private string _retentionConfigurationName;

        /// <summary>
        /// Gets and sets the property RetentionConfigurationName. 
        /// <para>
        /// The name of the retention configuration to delete.
        /// </para>
        /// </summary>
        public string RetentionConfigurationName
        {
            get { return this._retentionConfigurationName; }
            set { this._retentionConfigurationName = value; }
        }

        // Check to see if RetentionConfigurationName property is set
        internal bool IsSetRetentionConfigurationName()
        {
            return this._retentionConfigurationName != null;
        }

    }
}