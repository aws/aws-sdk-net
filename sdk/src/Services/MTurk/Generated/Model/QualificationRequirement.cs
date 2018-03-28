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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// The QualificationRequirement data structure describes a Qualification that a Worker
    /// must have before the Worker is allowed to accept a HIT. A requirement may optionally
    /// state that a Worker must have the Qualification in order to preview the HIT, or see
    /// the HIT in search results.
    /// </summary>
    public partial class QualificationRequirement
    {
        private HITAccessActions _actionsGuarded;
        private Comparator _comparator;
        private List<int> _integerValues = new List<int>();
        private List<Locale> _localeValues = new List<Locale>();
        private string _qualificationTypeId;
        private bool? _requiredToPreview;

        /// <summary>
        /// Gets and sets the property ActionsGuarded. 
        /// <para>
        ///  Setting this attribute prevents Workers whose Qualifications do not meet this QualificationRequirement
        /// from taking the specified action. Valid arguments include "Accept" (Worker cannot
        /// accept the HIT, but can preview the HIT and see it in their search results), "PreviewAndAccept"
        /// (Worker cannot accept or preview the HIT, but can see the HIT in their search results),
        /// and "DiscoverPreviewAndAccept" (Worker cannot accept, preview, or see the HIT in their
        /// search results). It's possible for you to create a HIT with multiple QualificationRequirements
        /// (which can have different values for the ActionGuarded attribute). In this case, the
        /// Worker is only permitted to perform an action when they have met all QualificationRequirements
        /// guarding the action. The actions in the order of least restrictive to most restrictive
        /// are Discover, Preview and Accept. For example, if a Worker meets all QualificationRequirements
        /// that are set to DiscoverPreviewAndAccept, but do not meet all requirements that are
        /// set with PreviewAndAccept, then the Worker will be able to Discover, i.e. see the
        /// HIT in their search result, but will not be able to Preview or Accept the HIT. ActionsGuarded
        /// should not be used in combination with the <code>RequiredToPreview</code> field. 
        /// </para>
        /// </summary>
        public HITAccessActions ActionsGuarded
        {
            get { return this._actionsGuarded; }
            set { this._actionsGuarded = value; }
        }

        // Check to see if ActionsGuarded property is set
        internal bool IsSetActionsGuarded()
        {
            return this._actionsGuarded != null;
        }

        /// <summary>
        /// Gets and sets the property Comparator. 
        /// <para>
        /// The kind of comparison to make against a Qualification's value. You can compare a
        /// Qualification's value to an IntegerValue to see if it is LessThan, LessThanOrEqualTo,
        /// GreaterThan, GreaterThanOrEqualTo, EqualTo, or NotEqualTo the IntegerValue. You can
        /// compare it to a LocaleValue to see if it is EqualTo, or NotEqualTo the LocaleValue.
        /// You can check to see if the value is In or NotIn a set of IntegerValue or LocaleValue
        /// values. Lastly, a Qualification requirement can also test if a Qualification Exists
        /// or DoesNotExist in the user's profile, regardless of its value. 
        /// </para>
        /// </summary>
        public Comparator Comparator
        {
            get { return this._comparator; }
            set { this._comparator = value; }
        }

        // Check to see if Comparator property is set
        internal bool IsSetComparator()
        {
            return this._comparator != null;
        }

        /// <summary>
        /// Gets and sets the property IntegerValues. 
        /// <para>
        ///  The integer value to compare against the Qualification's value. IntegerValue must
        /// not be present if Comparator is Exists or DoesNotExist. IntegerValue can only be used
        /// if the Qualification type has an integer value; it cannot be used with the Worker_Locale
        /// QualificationType ID. When performing a set comparison by using the In or the NotIn
        /// comparator, you can use up to 15 IntegerValue elements in a QualificationRequirement
        /// data structure. 
        /// </para>
        /// </summary>
        public List<int> IntegerValues
        {
            get { return this._integerValues; }
            set { this._integerValues = value; }
        }

        // Check to see if IntegerValues property is set
        internal bool IsSetIntegerValues()
        {
            return this._integerValues != null && this._integerValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocaleValues. 
        /// <para>
        ///  The locale value to compare against the Qualification's value. The local value must
        /// be a valid ISO 3166 country code or supports ISO 3166-2 subdivisions. LocaleValue
        /// can only be used with a Worker_Locale QualificationType ID. LocaleValue can only be
        /// used with the EqualTo, NotEqualTo, In, and NotIn comparators. You must only use a
        /// single LocaleValue element when using the EqualTo or NotEqualTo comparators. When
        /// performing a set comparison by using the In or the NotIn comparator, you can use up
        /// to 30 LocaleValue elements in a QualificationRequirement data structure. 
        /// </para>
        /// </summary>
        public List<Locale> LocaleValues
        {
            get { return this._localeValues; }
            set { this._localeValues = value; }
        }

        // Check to see if LocaleValues property is set
        internal bool IsSetLocaleValues()
        {
            return this._localeValues != null && this._localeValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        ///  The ID of the Qualification type for the requirement.
        /// </para>
        /// </summary>
        public string QualificationTypeId
        {
            get { return this._qualificationTypeId; }
            set { this._qualificationTypeId = value; }
        }

        // Check to see if QualificationTypeId property is set
        internal bool IsSetQualificationTypeId()
        {
            return this._qualificationTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredToPreview. 
        /// <para>
        ///  DEPRECATED: Use the <code>ActionsGuarded</code> field instead. If RequiredToPreview
        /// is true, the question data for the HIT will not be shown when a Worker whose Qualifications
        /// do not meet this requirement tries to preview the HIT. That is, a Worker's Qualifications
        /// must meet all of the requirements for which RequiredToPreview is true in order to
        /// preview the HIT. If a Worker meets all of the requirements where RequiredToPreview
        /// is true (or if there are no such requirements), but does not meet all of the requirements
        /// for the HIT, the Worker will be allowed to preview the HIT's question data, but will
        /// not be allowed to accept and complete the HIT. The default is false. This should not
        /// be used in combination with the <code>ActionsGuarded</code> field. 
        /// </para>
        /// </summary>
        public bool RequiredToPreview
        {
            get { return this._requiredToPreview.GetValueOrDefault(); }
            set { this._requiredToPreview = value; }
        }

        // Check to see if RequiredToPreview property is set
        internal bool IsSetRequiredToPreview()
        {
            return this._requiredToPreview.HasValue; 
        }

    }
}