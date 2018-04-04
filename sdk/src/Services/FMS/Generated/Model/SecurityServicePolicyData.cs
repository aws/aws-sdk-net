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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details about the security service that is being used to protect the resources.
    /// </summary>
    public partial class SecurityServicePolicyData
    {
        private string _managedServiceData;
        private SecurityServiceType _type;

        /// <summary>
        /// Gets and sets the property ManagedServiceData. 
        /// <para>
        /// Details about the service. This contains <code>WAF</code> data in JSON format, as
        /// shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>ManagedServiceData": "{\"type\": \"WAF\", \"ruleGroups\": [{\"id\": \"12345678-1bcd-9012-efga-0987654321ab\",
        /// \"overrideAction\" : {\"type\": \"COUNT\"}}], \"defaultAction\": {\"type\": \"BLOCK\"}}</code>
        /// 
        /// </para>
        /// </summary>
        public string ManagedServiceData
        {
            get { return this._managedServiceData; }
            set { this._managedServiceData = value; }
        }

        // Check to see if ManagedServiceData property is set
        internal bool IsSetManagedServiceData()
        {
            return this._managedServiceData != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The service that the policy is using to protect the resources. This value is <code>WAF</code>.
        /// </para>
        /// </summary>
        public SecurityServiceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}