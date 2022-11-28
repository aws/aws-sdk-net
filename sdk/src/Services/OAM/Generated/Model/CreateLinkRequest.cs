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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLink operation.
    /// Creates a link between a source account and a sink that you have created in a monitoring
    /// account.
    /// 
    ///  
    /// <para>
    /// Before you create a link, you must create a sink in the monitoring account and create
    /// a sink policy in that account. The sink policy must permit the source account to link
    /// to it. You can grant permission to source accounts by granting permission to an entire
    /// organization or to individual accounts.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_CreateSink.html">CreateSink</a>
    /// and <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_PutSinkPolicy.html">PutSinkPolicy</a>.
    /// </para>
    ///  
    /// <para>
    /// Each monitoring account can be linked to as many as 100,000 source accounts.
    /// </para>
    ///  
    /// <para>
    /// Each source account can be linked to as many as five monitoring accounts.
    /// </para>
    /// </summary>
    public partial class CreateLinkRequest : AmazonOAMRequest
    {
        private string _labelTemplate;
        private List<string> _resourceTypes = new List<string>();
        private string _sinkIdentifier;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property LabelTemplate. 
        /// <para>
        /// Specify a friendly human-readable name to use to identify this source account when
        /// you are viewing data from it in the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// You can use a custom label or use the following variables:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>$AccountName</code> is the name of the account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>$AccountEmail</code> is the globally unique email address of the account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>$AccountEmailNoDomain</code> is the email address of the account without the
        /// domain name
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string LabelTemplate
        {
            get { return this._labelTemplate; }
            set { this._labelTemplate = value; }
        }

        // Check to see if LabelTemplate property is set
        internal bool IsSetLabelTemplate()
        {
            return this._labelTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// An array of strings that define which types of data that the source account shares
        /// with the monitoring account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SinkIdentifier. 
        /// <para>
        /// The ARN of the sink to use to create this link. You can use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>
        /// to find the ARNs of sinks.
        /// </para>
        ///  
        /// <para>
        /// For more information about sinks, see <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_CreateSink.html">CreateSink</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SinkIdentifier
        {
            get { return this._sinkIdentifier; }
            set { this._sinkIdentifier = value; }
        }

        // Check to see if SinkIdentifier property is set
        internal bool IsSetSinkIdentifier()
        {
            return this._sinkIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the link. 
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// For more information about using tags to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}