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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A set of instructions that define how Amazon Q Business should generate and format
    /// responses to user queries. This collection includes parameters for controlling response
    /// characteristics such as length, audience targeting, perspective, style, identity,
    /// tone, and custom instructions.
    /// </summary>
    public partial class InstructionCollection
    {
        private string _customInstructions;
        private string _examples;
        private string _identity;
        private string _outputStyle;
        private string _perspective;
        private string _responseLength;
        private string _targetAudience;
        private string _tone;

        /// <summary>
        /// Gets and sets the property CustomInstructions. 
        /// <para>
        /// Allows administrators to provide specific, custom instructions that guide how Amazon
        /// Q Business should respond in particular scenarios or to certain types of queries,
        /// enabling fine-grained control over response generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string CustomInstructions
        {
            get { return this._customInstructions; }
            set { this._customInstructions = value; }
        }

        // Check to see if CustomInstructions property is set
        internal bool IsSetCustomInstructions()
        {
            return this._customInstructions != null;
        }

        /// <summary>
        /// Gets and sets the property Examples. 
        /// <para>
        /// Provides sample responses or templates that Amazon Q Business can reference when generating
        /// responses, helping to establish consistent patterns and formats for different types
        /// of user queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string Examples
        {
            get { return this._examples; }
            set { this._examples = value; }
        }

        // Check to see if Examples property is set
        internal bool IsSetExamples()
        {
            return this._examples != null;
        }

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// Defines the persona or identity that Amazon Q Business should adopt when responding
        /// to users, allowing for customization of the assistant's character, role, or representation
        /// within an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string Identity
        {
            get { return this._identity; }
            set { this._identity = value; }
        }

        // Check to see if Identity property is set
        internal bool IsSetIdentity()
        {
            return this._identity != null;
        }

        /// <summary>
        /// Gets and sets the property OutputStyle. 
        /// <para>
        /// Specifies the formatting and structural style of responses, such as bullet points,
        /// paragraphs, step-by-step instructions, or other organizational formats that enhance
        /// readability and comprehension.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string OutputStyle
        {
            get { return this._outputStyle; }
            set { this._outputStyle = value; }
        }

        // Check to see if OutputStyle property is set
        internal bool IsSetOutputStyle()
        {
            return this._outputStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Perspective. 
        /// <para>
        /// Determines the point of view or perspective from which Amazon Q Business generates
        /// responses, such as first-person, second-person, or third-person perspective, affecting
        /// how information is presented to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string Perspective
        {
            get { return this._perspective; }
            set { this._perspective = value; }
        }

        // Check to see if Perspective property is set
        internal bool IsSetPerspective()
        {
            return this._perspective != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseLength. 
        /// <para>
        /// Specifies the desired length of responses generated by Amazon Q Business. This parameter
        /// allows administrators to control whether responses are concise and brief or more detailed
        /// and comprehensive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string ResponseLength
        {
            get { return this._responseLength; }
            set { this._responseLength = value; }
        }

        // Check to see if ResponseLength property is set
        internal bool IsSetResponseLength()
        {
            return this._responseLength != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAudience. 
        /// <para>
        /// Defines the intended audience for the responses, allowing Amazon Q Business to tailor
        /// its language, terminology, and explanations appropriately. This could range from technical
        /// experts to general users with varying levels of domain knowledge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string TargetAudience
        {
            get { return this._targetAudience; }
            set { this._targetAudience = value; }
        }

        // Check to see if TargetAudience property is set
        internal bool IsSetTargetAudience()
        {
            return this._targetAudience != null;
        }

        /// <summary>
        /// Gets and sets the property Tone. 
        /// <para>
        /// Controls the emotional tone and communication style of responses, such as formal,
        /// casual, technical, friendly, or professional, to align with organizational communication
        /// standards and user expectations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
        public string Tone
        {
            get { return this._tone; }
            set { this._tone = value; }
        }

        // Check to see if Tone property is set
        internal bool IsSetTone()
        {
            return this._tone != null;
        }

    }
}