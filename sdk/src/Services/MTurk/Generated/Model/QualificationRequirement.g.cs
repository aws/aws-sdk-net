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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The QualificationRequirement data structure describes a Qualification that a Worker
    /// must have before the Worker is allowed to accept a HIT. A requirement may optionally
    /// state that a Worker must have the Qualification in order to preview the HIT, or see
    /// the HIT in search results.
    /// </summary>
    public partial class QualificationRequirement
    {
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
        /// should not be used in combination with the <c>RequiredToPreview</c> field. 
        /// </para>
        /// </summary>
        public HITAccessActions ActionsGuarded { get; set; }

        /// <summary>
        /// Checks to see if the ActionsGuarded property is set.
        /// </summary>
        internal bool IsSetActionsGuarded() => this.ActionsGuarded != null;

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
        [AWSProperty(Required = true)]
        public Comparator Comparator { get; set; }

        /// <summary>
        /// Checks to see if the Comparator property is set.
        /// </summary>
        internal bool IsSetComparator() => this.Comparator != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IntegerValues { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the IntegerValues property is set.
        /// </summary>
        internal bool IsSetIntegerValues() => this.IntegerValues != null && (this.IntegerValues.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Locale> LocaleValues { get; set; } = AWSConfigs.InitializeCollections ? new List<Locale>() : null;

        /// <summary>
        /// Checks to see if the LocaleValues property is set.
        /// </summary>
        internal bool IsSetLocaleValues() => this.LocaleValues != null && (this.LocaleValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QualificationTypeId. 
        /// <para>
        ///  The ID of the Qualification type for the requirement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QualificationTypeId { get; set; }

        /// <summary>
        /// Checks to see if the QualificationTypeId property is set.
        /// </summary>
        internal bool IsSetQualificationTypeId() => this.QualificationTypeId != null;

        /// <summary>
        /// Gets and sets the property RequiredToPreview. 
        /// <para>
        ///  DEPRECATED: Use the <c>ActionsGuarded</c> field instead. If RequiredToPreview is
        /// true, the question data for the HIT will not be shown when a Worker whose Qualifications
        /// do not meet this requirement tries to preview the HIT. That is, a Worker's Qualifications
        /// must meet all of the requirements for which RequiredToPreview is true in order to
        /// preview the HIT. If a Worker meets all of the requirements where RequiredToPreview
        /// is true (or if there are no such requirements), but does not meet all of the requirements
        /// for the HIT, the Worker will be allowed to preview the HIT's question data, but will
        /// not be allowed to accept and complete the HIT. The default is false. This should not
        /// be used in combination with the <c>ActionsGuarded</c> field. 
        /// </para>
        /// </summary>
        [Obsolete("Use the ActionsGuarded field instead")]
        public bool? RequiredToPreview { get; set; }

        /// <summary>
        /// Checks to see if the RequiredToPreview property is set.
        /// </summary>
        internal bool IsSetRequiredToPreview() => this.RequiredToPreview.HasValue;
    }
}
