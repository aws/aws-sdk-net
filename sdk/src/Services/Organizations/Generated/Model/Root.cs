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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details about a root. A root is a top-level parent node in the hierarchy
    /// of an organization that can contain organizational units (OUs) and accounts. The root
    /// contains every Amazon Web Services account in the organization.
    /// </summary>
    public partial class Root
    {
        private string _arn;
        private string _id;
        private string _name;
        private List<PolicyTypeSummary> _policyTypes = AWSConfigs.InitializeCollections ? new List<PolicyTypeSummary>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the root.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs in Organizations, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsorganizations.html#awsorganizations-resources-for-iam-policies">ARN
        /// Formats Supported by Organizations</a> in the <i>Amazon Web Services Service Authorization
        /// Reference</i>.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) for the root. The ID is unique to the organization only.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for a root ID string
        /// requires "r-" followed by from 4 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Max=34)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the root.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> that is used to validate
        /// this parameter is a string of any of the characters in the ASCII character range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTypes. 
        /// <para>
        /// The types of policies that are currently enabled for the root and therefore can be
        /// attached to the root or to its OUs or accounts.
        /// </para>
        ///  <note> 
        /// <para>
        /// Even if a policy type is shown as available in the organization, you can separately
        /// enable and disable them at the root level by using <a>EnablePolicyType</a> and <a>DisablePolicyType</a>.
        /// Use <a>DescribeOrganization</a> to see the availability of the policy types in that
        /// organization.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicyTypeSummary> PolicyTypes
        {
            get { return this._policyTypes; }
            set { this._policyTypes = value; }
        }

        // Check to see if PolicyTypes property is set
        internal bool IsSetPolicyTypes()
        {
            return this._policyTypes != null && (this._policyTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}