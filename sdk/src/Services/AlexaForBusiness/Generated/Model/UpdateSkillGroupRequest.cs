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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSkillGroup operation.
    /// Updates skill group details by skill group ARN.
    /// </summary>
    public partial class UpdateSkillGroupRequest : AmazonAlexaForBusinessRequest
    {
        private string _description;
        private string _skillGroupArn;
        private string _skillGroupName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the skill group.
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
        /// Gets and sets the property SkillGroupArn. 
        /// <para>
        /// The ARN of the skill group to update. 
        /// </para>
        /// </summary>
        public string SkillGroupArn
        {
            get { return this._skillGroupArn; }
            set { this._skillGroupArn = value; }
        }

        // Check to see if SkillGroupArn property is set
        internal bool IsSetSkillGroupArn()
        {
            return this._skillGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SkillGroupName. 
        /// <para>
        /// The updated name for the skill group.
        /// </para>
        /// </summary>
        public string SkillGroupName
        {
            get { return this._skillGroupName; }
            set { this._skillGroupName = value; }
        }

        // Check to see if SkillGroupName property is set
        internal bool IsSetSkillGroupName()
        {
            return this._skillGroupName != null;
        }

    }
}