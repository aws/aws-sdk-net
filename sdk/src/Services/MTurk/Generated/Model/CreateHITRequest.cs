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
    /// Container for the parameters to the CreateHIT operation.
    /// The <c>CreateHIT</c> operation creates a new Human Intelligence Task (HIT). The new
    /// HIT is made available for Workers to find and accept on the Amazon Mechanical Turk
    /// website. 
    /// 
    ///  
    /// <para>
    ///  This operation allows you to specify a new HIT by passing in values for the properties
    /// of the HIT, such as its title, reward amount and number of assignments. When you pass
    /// these values to <c>CreateHIT</c>, a new HIT is created for you, with a new <c>HITTypeID</c>.
    /// The HITTypeID can be used to create additional HITs in the future without needing
    /// to specify common parameters such as the title, description and reward amount each
    /// time.
    /// </para>
    ///  
    /// <para>
    ///  An alternative way to create HITs is to first generate a HITTypeID using the <c>CreateHITType</c>
    /// operation and then call the <c>CreateHITWithHITType</c> operation. This is the recommended
    /// best practice for Requesters who are creating large numbers of HITs. 
    /// </para>
    ///  
    /// <para>
    /// CreateHIT also supports several ways to provide question data: by providing a value
    /// for the <c>Question</c> parameter that fully specifies the contents of the HIT, or
    /// by providing a <c>HitLayoutId</c> and associated <c>HitLayoutParameters</c>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
    /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
    /// Turk Pricing</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateHITRequest : AmazonMTurkRequest
    {
        private long? _assignmentDurationInSeconds;
        private ReviewPolicy _assignmentReviewPolicy;
        private long? _autoApprovalDelayInSeconds;
        private string _description;
        private string _hitLayoutId;
        private List<HITLayoutParameter> _hitLayoutParameters = AWSConfigs.InitializeCollections ? new List<HITLayoutParameter>() : null;
        private ReviewPolicy _hitReviewPolicy;
        private string _keywords;
        private long? _lifetimeInSeconds;
        private int? _maxAssignments;
        private List<QualificationRequirement> _qualificationRequirements = AWSConfigs.InitializeCollections ? new List<QualificationRequirement>() : null;
        private string _question;
        private string _requesterAnnotation;
        private string _reward;
        private string _title;
        private string _uniqueRequestToken;

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
        /// Gets and sets the property AssignmentReviewPolicy. 
        /// <para>
        ///  The Assignment-level Review Policy applies to the assignments under the HIT. You
        /// can specify for Mechanical Turk to take various actions based on the policy. 
        /// </para>
        /// </summary>
        public ReviewPolicy AssignmentReviewPolicy
        {
            get { return this._assignmentReviewPolicy; }
            set { this._assignmentReviewPolicy = value; }
        }

        // Check to see if AssignmentReviewPolicy property is set
        internal bool IsSetAssignmentReviewPolicy()
        {
            return this._assignmentReviewPolicy != null;
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
        /// Gets and sets the property HITLayoutId. 
        /// <para>
        ///  The HITLayoutId allows you to use a pre-existing HIT design with placeholder values
        /// and create an additional HIT by providing those values as HITLayoutParameters. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Either a Question parameter or a HITLayoutId parameter must be provided.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string HITLayoutId
        {
            get { return this._hitLayoutId; }
            set { this._hitLayoutId = value; }
        }

        // Check to see if HITLayoutId property is set
        internal bool IsSetHITLayoutId()
        {
            return this._hitLayoutId != null;
        }

        /// <summary>
        /// Gets and sets the property HITLayoutParameters. 
        /// <para>
        ///  If the HITLayoutId is provided, any placeholder values must be filled in with values
        /// using the HITLayoutParameter structure. For more information, see HITLayout. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HITLayoutParameter> HITLayoutParameters
        {
            get { return this._hitLayoutParameters; }
            set { this._hitLayoutParameters = value; }
        }

        // Check to see if HITLayoutParameters property is set
        internal bool IsSetHITLayoutParameters()
        {
            return this._hitLayoutParameters != null && (this._hitLayoutParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HITReviewPolicy. 
        /// <para>
        ///  The HIT-level Review Policy applies to the HIT. You can specify for Mechanical Turk
        /// to take various actions based on the policy. 
        /// </para>
        /// </summary>
        public ReviewPolicy HITReviewPolicy
        {
            get { return this._hitReviewPolicy; }
            set { this._hitReviewPolicy = value; }
        }

        // Check to see if HITReviewPolicy property is set
        internal bool IsSetHITReviewPolicy()
        {
            return this._hitReviewPolicy != null;
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
        /// Gets and sets the property LifetimeInSeconds. 
        /// <para>
        ///  An amount of time, in seconds, after which the HIT is no longer available for users
        /// to accept. After the lifetime of the HIT elapses, the HIT no longer appears in HIT
        /// searches, even if not all of the assignments for the HIT have been accepted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? LifetimeInSeconds
        {
            get { return this._lifetimeInSeconds; }
            set { this._lifetimeInSeconds = value; }
        }

        // Check to see if LifetimeInSeconds property is set
        internal bool IsSetLifetimeInSeconds()
        {
            return this._lifetimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAssignments. 
        /// <para>
        ///  The number of times the HIT can be accepted and completed before the HIT becomes
        /// unavailable. 
        /// </para>
        /// </summary>
        public int? MaxAssignments
        {
            get { return this._maxAssignments; }
            set { this._maxAssignments = value; }
        }

        // Check to see if MaxAssignments property is set
        internal bool IsSetMaxAssignments()
        {
            return this._maxAssignments.HasValue; 
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
        /// Gets and sets the property Question. 
        /// <para>
        ///  The data the person completing the HIT uses to produce the results. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be a QuestionForm data structure, an ExternalQuestion data structure,
        /// or an HTMLQuestion data structure. The XML question data must not be larger than 64
        /// kilobytes (65,535 bytes) in size, including whitespace. 
        /// </para>
        ///  
        /// <para>
        /// Either a Question parameter or a HITLayoutId parameter must be provided.
        /// </para>
        /// </summary>
        public string Question
        {
            get { return this._question; }
            set { this._question = value; }
        }

        // Check to see if Question property is set
        internal bool IsSetQuestion()
        {
            return this._question != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterAnnotation. 
        /// <para>
        ///  An arbitrary data field. The RequesterAnnotation parameter lets your application
        /// attach arbitrary data to the HIT for tracking purposes. For example, this parameter
        /// could be an identifier internal to the Requester's application that corresponds with
        /// the HIT. 
        /// </para>
        ///  
        /// <para>
        ///  The RequesterAnnotation parameter for a HIT is only visible to the Requester who
        /// created the HIT. It is not shown to the Worker, or any other Requester. 
        /// </para>
        ///  
        /// <para>
        ///  The RequesterAnnotation parameter may be different for each HIT you submit. It does
        /// not affect how your HITs are grouped. 
        /// </para>
        /// </summary>
        public string RequesterAnnotation
        {
            get { return this._requesterAnnotation; }
            set { this._requesterAnnotation = value; }
        }

        // Check to see if RequesterAnnotation property is set
        internal bool IsSetRequesterAnnotation()
        {
            return this._requesterAnnotation != null;
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

        /// <summary>
        /// Gets and sets the property UniqueRequestToken. 
        /// <para>
        ///  A unique identifier for this request which allows you to retry the call on error
        /// without creating duplicate HITs. This is useful in cases such as network timeouts
        /// where it is unclear whether or not the call succeeded on the server. If the HIT already
        /// exists in the system from a previous call using the same UniqueRequestToken, subsequent
        /// calls will return a AWS.MechanicalTurk.HitAlreadyExists error with a message containing
        /// the HITId. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Note: It is your responsibility to ensure uniqueness of the token. The unique token
        /// expires after 24 hours. Subsequent calls using the same UniqueRequestToken made after
        /// the 24 hour limit could create duplicate HITs. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string UniqueRequestToken
        {
            get { return this._uniqueRequestToken; }
            set { this._uniqueRequestToken = value; }
        }

        // Check to see if UniqueRequestToken property is set
        internal bool IsSetUniqueRequestToken()
        {
            return this._uniqueRequestToken != null;
        }

    }
}