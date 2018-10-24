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
    /// Granular information about the skill.
    /// </summary>
    public partial class SkillDetails
    {
        private List<string> _bulletPoints = new List<string>();
        private DeveloperInfo _developerInfo;
        private string _endUserLicenseAgreement;
        private List<string> _genericKeywords = new List<string>();
        private string _invocationPhrase;
        private List<string> _newInThisVersionBulletPoints = new List<string>();
        private string _productDescription;
        private string _releaseDate;
        private Dictionary<string, string> _reviews = new Dictionary<string, string>();
        private List<string> _skillTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property BulletPoints. 
        /// <para>
        /// The details about what the skill supports organized as bullet points.
        /// </para>
        /// </summary>
        public List<string> BulletPoints
        {
            get { return this._bulletPoints; }
            set { this._bulletPoints = value; }
        }

        // Check to see if BulletPoints property is set
        internal bool IsSetBulletPoints()
        {
            return this._bulletPoints != null && this._bulletPoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeveloperInfo. 
        /// <para>
        /// The details about the developer that published the skill.
        /// </para>
        /// </summary>
        public DeveloperInfo DeveloperInfo
        {
            get { return this._developerInfo; }
            set { this._developerInfo = value; }
        }

        // Check to see if DeveloperInfo property is set
        internal bool IsSetDeveloperInfo()
        {
            return this._developerInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EndUserLicenseAgreement. 
        /// <para>
        /// The URL of the end user license agreement.
        /// </para>
        /// </summary>
        public string EndUserLicenseAgreement
        {
            get { return this._endUserLicenseAgreement; }
            set { this._endUserLicenseAgreement = value; }
        }

        // Check to see if EndUserLicenseAgreement property is set
        internal bool IsSetEndUserLicenseAgreement()
        {
            return this._endUserLicenseAgreement != null;
        }

        /// <summary>
        /// Gets and sets the property GenericKeywords. 
        /// <para>
        /// The generic keywords associated with the skill that can be used to find a skill.
        /// </para>
        /// </summary>
        public List<string> GenericKeywords
        {
            get { return this._genericKeywords; }
            set { this._genericKeywords = value; }
        }

        // Check to see if GenericKeywords property is set
        internal bool IsSetGenericKeywords()
        {
            return this._genericKeywords != null && this._genericKeywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InvocationPhrase. 
        /// <para>
        /// The phrase used to trigger the skill.
        /// </para>
        /// </summary>
        public string InvocationPhrase
        {
            get { return this._invocationPhrase; }
            set { this._invocationPhrase = value; }
        }

        // Check to see if InvocationPhrase property is set
        internal bool IsSetInvocationPhrase()
        {
            return this._invocationPhrase != null;
        }

        /// <summary>
        /// Gets and sets the property NewInThisVersionBulletPoints. 
        /// <para>
        /// The updates added in bullet points.
        /// </para>
        /// </summary>
        public List<string> NewInThisVersionBulletPoints
        {
            get { return this._newInThisVersionBulletPoints; }
            set { this._newInThisVersionBulletPoints = value; }
        }

        // Check to see if NewInThisVersionBulletPoints property is set
        internal bool IsSetNewInThisVersionBulletPoints()
        {
            return this._newInThisVersionBulletPoints != null && this._newInThisVersionBulletPoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The description of the product.
        /// </para>
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date when the skill was released.
        /// </para>
        /// </summary>
        public string ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate != null;
        }

        /// <summary>
        /// Gets and sets the property Reviews. 
        /// <para>
        /// The list of reviews for the skill, including Key and Value pair.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Reviews
        {
            get { return this._reviews; }
            set { this._reviews = value; }
        }

        // Check to see if Reviews property is set
        internal bool IsSetReviews()
        {
            return this._reviews != null && this._reviews.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SkillTypes. 
        /// <para>
        /// The types of skills.
        /// </para>
        /// </summary>
        public List<string> SkillTypes
        {
            get { return this._skillTypes; }
            set { this._skillTypes = value; }
        }

        // Check to see if SkillTypes property is set
        internal bool IsSetSkillTypes()
        {
            return this._skillTypes != null && this._skillTypes.Count > 0; 
        }

    }
}