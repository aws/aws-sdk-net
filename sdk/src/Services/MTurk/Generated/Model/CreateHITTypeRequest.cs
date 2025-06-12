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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHITType operation.
    /// The <c>CreateHITType</c> operation creates a new HIT type. This operation allows
    /// you to define a standard set of HIT properties to use when creating HITs. If you register
    /// a HIT type with values that match an existing HIT type, the HIT type ID of the existing
    /// type will be returned.
    /// </summary>
    public partial class CreateHITTypeRequest : AmazonMTurkRequest
    {
        private long? _assignmentDurationInSeconds;
        private long? _autoApprovalDelayInSeconds;
        private string _description;
        private string _keywords;
        private List<QualificationRequirement> _qualificationRequirements = AWSConfigs.InitializeCollections ? new List<QualificationRequirement>() : null;
        private string _reward;
        private string _title;

        /// <summary>
        /// Gets and sets the property AssignmentDurationInSeconds. 
        /// <para>
        ///  The amount of time, in seconds, that a Worker has to complete the HIT after accepting
        /// it. If a Worker does not complete the assignment within the specified duration, the
        /// assignment is considered abandoned. If the HIT is still active (that is, its lifetime
        /// has not elapsed), the assignment becomes available for other users to find and accept.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? AssignmentDurationInSeconds
        {
            get { return this._assignmentDurationInSeconds; }
            set { this._assignmentDurationInSeconds = value; }
        }

        // Check to see if AssignmentDurationInSeconds property is set
        internal bool IsSetAssignmentDurationInSeconds()
        {
            return this._assignmentDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoApprovalDelayInSeconds. 
        /// <para>
        ///  The number of seconds after an assignment for the HIT has been submitted, after which
        /// the assignment is considered Approved automatically unless the Requester explicitly
        /// rejects it. 
        /// </para>
        /// </summary>
        public long? AutoApprovalDelayInSeconds
        {
            get { return this._autoApprovalDelayInSeconds; }
            set { this._autoApprovalDelayInSeconds = value; }
        }

        // Check to see if AutoApprovalDelayInSeconds property is set
        internal bool IsSetAutoApprovalDelayInSeconds()
        {
            return this._autoApprovalDelayInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A general description of the HIT. A description includes detailed information about
        /// the kind of task the HIT contains. On the Amazon Mechanical Turk web site, the HIT
        /// description appears in the expanded view of search results, and in the HIT and assignment
        /// screens. A good description gives the user enough information to evaluate the HIT
        /// before accepting it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Keywords. 
        /// <para>
        ///  One or more words or phrases that describe the HIT, separated by commas. These words
        /// are used in searches to find HITs. 
        /// </para>
        /// </summary>
        public string Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null;
        }

        /// <summary>
        /// Gets and sets the property QualificationRequirements. 
        /// <para>
        ///  Conditions that a Worker's Qualifications must meet in order to accept the HIT. A
        /// HIT can have between zero and ten Qualification requirements. All requirements must
        /// be met in order for a Worker to accept the HIT. Additionally, other actions can be
        /// restricted using the <c>ActionsGuarded</c> field on each <c>QualificationRequirement</c>
        /// structure. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QualificationRequirement> QualificationRequirements
        {
            get { return this._qualificationRequirements; }
            set { this._qualificationRequirements = value; }
        }

        // Check to see if QualificationRequirements property is set
        internal bool IsSetQualificationRequirements()
        {
            return this._qualificationRequirements != null && (this._qualificationRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Reward. 
        /// <para>
        ///  The amount of money the Requester will pay a Worker for successfully completing the
        /// HIT. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Reward
        {
            get { return this._reward; }
            set { this._reward = value; }
        }

        // Check to see if Reward property is set
        internal bool IsSetReward()
        {
            return this._reward != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of the HIT. A title should be short and descriptive about the kind of task
        /// the HIT contains. On the Amazon Mechanical Turk web site, the HIT title appears in
        /// search results, and everywhere the HIT is mentioned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}