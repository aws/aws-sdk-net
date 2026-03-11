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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTieringConfiguration operation.
    /// This request will send changes to your specified tiering configuration. <c>TieringConfigurationName</c>
    /// cannot be updated after it is created.
    /// 
    ///  
    /// <para>
    ///  <c>ResourceSelection</c> can contain:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Resources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TieringDownSettingsInDays</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ResourceType</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateTieringConfigurationRequest : AmazonBackupRequest
    {
        private TieringConfigurationInputForUpdate _tieringConfiguration;
        private string _tieringConfigurationName;

        /// <summary>
        /// Gets and sets the property TieringConfiguration. 
        /// <para>
        /// Specifies the body of a tiering configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TieringConfigurationInputForUpdate TieringConfiguration
        {
            get { return this._tieringConfiguration; }
            set { this._tieringConfiguration = value; }
        }

        // Check to see if TieringConfiguration property is set
        internal bool IsSetTieringConfiguration()
        {
            return this._tieringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TieringConfigurationName. 
        /// <para>
        /// The name of a tiering configuration to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TieringConfigurationName
        {
            get { return this._tieringConfigurationName; }
            set { this._tieringConfigurationName = value; }
        }

        // Check to see if TieringConfigurationName property is set
        internal bool IsSetTieringConfigurationName()
        {
            return this._tieringConfigurationName != null;
        }

    }
}