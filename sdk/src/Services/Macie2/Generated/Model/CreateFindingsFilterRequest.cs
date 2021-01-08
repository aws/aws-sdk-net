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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFindingsFilter operation.
    /// Creates and defines the criteria and other settings for a findings filter.
    /// </summary>
    public partial class CreateFindingsFilterRequest : AmazonMacie2Request
    {
        private FindingsFilterAction _action;
        private string _clientToken;
        private string _description;
        private FindingCriteria _findingCriteria;
        private string _name;
        private int? _position;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to perform on findings that meet the filter criteria (findingCriteria).
        /// Valid values are: ARCHIVE, suppress (automatically archive) the findings; and, NOOP,
        /// don't perform any action on the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingsFilterAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A custom description of the filter. The description can contain as many as 512 characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the description
        /// of a filter. Other users of your account might be able to see the filter's description,
        /// depending on the actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// The criteria to use to filter findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingCriteria FindingCriteria
        {
            get { return this._findingCriteria; }
            set { this._findingCriteria = value; }
        }

        // Check to see if FindingCriteria property is set
        internal bool IsSetFindingCriteria()
        {
            return this._findingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A custom name for the filter. The name must contain at least 3 characters and can
        /// contain as many as 64 characters.
        /// </para>
        ///  
        /// <para>
        /// We strongly recommend that you avoid including any sensitive data in the name of a
        /// filter. Other users of your account might be able to see the filter's name, depending
        /// on the actions that they're allowed to perform in Amazon Macie.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Position. 
        /// <para>
        /// The position of the filter in the list of saved filters on the Amazon Macie console.
        /// This value also determines the order in which the filter is applied to findings, relative
        /// to other filters that are also applied to the findings.
        /// </para>
        /// </summary>
        public int Position
        {
            get { return this._position.GetValueOrDefault(); }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs that specifies the tags to associate with the filter.
        /// </para>
        ///  
        /// <para>
        /// A findings filter can have a maximum of 50 tags. Each tag consists of a tag key and
        /// an associated tag value. The maximum length of a tag key is 128 characters. The maximum
        /// length of a tag value is 256 characters.
        /// </para>
        /// </summary>
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