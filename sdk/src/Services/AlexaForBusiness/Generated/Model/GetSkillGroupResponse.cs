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
    /// This is the response object from the GetSkillGroup operation.
    /// </summary>
    public partial class GetSkillGroupResponse : AmazonWebServiceResponse
    {
        private SkillGroup _skillGroup;

        /// <summary>
        /// Gets and sets the property SkillGroup. 
        /// <para>
        /// The details of the skill group requested. Required.
        /// </para>
        /// </summary>
        public SkillGroup SkillGroup
        {
            get { return this._skillGroup; }
            set { this._skillGroup = value; }
        }

        // Check to see if SkillGroup property is set
        internal bool IsSetSkillGroup()
        {
            return this._skillGroup != null;
        }

    }
}