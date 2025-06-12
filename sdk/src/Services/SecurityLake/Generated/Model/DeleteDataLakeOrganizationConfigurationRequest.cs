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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataLakeOrganizationConfiguration operation.
    /// Turns off automatic enablement of Amazon Security Lake for member accounts that are
    /// added to an organization in Organizations. Only the delegated Security Lake administrator
    /// for an organization can perform this operation. If the delegated Security Lake administrator
    /// performs this operation, new member accounts won't automatically contribute data to
    /// the data lake.
    /// </summary>
    public partial class DeleteDataLakeOrganizationConfigurationRequest : AmazonSecurityLakeRequest
    {
        private List<DataLakeAutoEnableNewAccountConfiguration> _autoEnableNewAccount = AWSConfigs.InitializeCollections ? new List<DataLakeAutoEnableNewAccountConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property AutoEnableNewAccount. 
        /// <para>
        /// Turns off automatic enablement of Security Lake for member accounts that are added
        /// to an organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DataLakeAutoEnableNewAccountConfiguration> AutoEnableNewAccount
        {
            get { return this._autoEnableNewAccount; }
            set { this._autoEnableNewAccount = value; }
        }

        // Check to see if AutoEnableNewAccount property is set
        internal bool IsSetAutoEnableNewAccount()
        {
            return this._autoEnableNewAccount != null && (this._autoEnableNewAccount.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}