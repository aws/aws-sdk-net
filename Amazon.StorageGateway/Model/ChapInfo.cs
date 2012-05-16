/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>Describes Challenge-Handshake Authentication Protocol (CHAP) information that supports authentication between your gateway and iSCSI
    /// initiators.</para>
    /// </summary>
    public class ChapInfo  
    {
        
        private string targetARN;
        private string secretToAuthenticateInitiator;
        private string initiatorName;
        private string secretToAuthenticateTarget;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the volume. <i>Valid Values</i>: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 800</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetARN
        {
            get { return this.targetARN; }
            set { this.targetARN = value; }
        }

        /// <summary>
        /// Sets the TargetARN property
        /// </summary>
        /// <param name="targetARN">The value to set for the TargetARN property </param>
        /// <returns>this instance</returns>
        public ChapInfo WithTargetARN(string targetARN)
        {
            this.targetARN = targetARN;
            return this;
        }
            

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;       
        }

        /// <summary>
        /// The secret key that the initiator (e.g. Windows client) must provide to participate in mutual CHAP with the target. Length: 12 to 16.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>12 - 16</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SecretToAuthenticateInitiator
        {
            get { return this.secretToAuthenticateInitiator; }
            set { this.secretToAuthenticateInitiator = value; }
        }

        /// <summary>
        /// Sets the SecretToAuthenticateInitiator property
        /// </summary>
        /// <param name="secretToAuthenticateInitiator">The value to set for the SecretToAuthenticateInitiator property </param>
        /// <returns>this instance</returns>
        public ChapInfo WithSecretToAuthenticateInitiator(string secretToAuthenticateInitiator)
        {
            this.secretToAuthenticateInitiator = secretToAuthenticateInitiator;
            return this;
        }
            

        // Check to see if SecretToAuthenticateInitiator property is set
        internal bool IsSetSecretToAuthenticateInitiator()
        {
            return this.secretToAuthenticateInitiator != null;       
        }

        /// <summary>
        /// The iSCSI initiator that connects to the target. Length: Minimum length of 1. Maximum length of 255. <i>Valid Values</i>: The target name
        /// can contain lowercase letters, numbers, periods (.), and hyphens (-).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[0-9a-z:.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InitiatorName
        {
            get { return this.initiatorName; }
            set { this.initiatorName = value; }
        }

        /// <summary>
        /// Sets the InitiatorName property
        /// </summary>
        /// <param name="initiatorName">The value to set for the InitiatorName property </param>
        /// <returns>this instance</returns>
        public ChapInfo WithInitiatorName(string initiatorName)
        {
            this.initiatorName = initiatorName;
            return this;
        }
            

        // Check to see if InitiatorName property is set
        internal bool IsSetInitiatorName()
        {
            return this.initiatorName != null;       
        }

        /// <summary>
        /// The secret key that the target must provide to participate in mutual CHAP with the initiator (e.g. Windows client). Length: 12 to 16.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>12 - 16</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SecretToAuthenticateTarget
        {
            get { return this.secretToAuthenticateTarget; }
            set { this.secretToAuthenticateTarget = value; }
        }

        /// <summary>
        /// Sets the SecretToAuthenticateTarget property
        /// </summary>
        /// <param name="secretToAuthenticateTarget">The value to set for the SecretToAuthenticateTarget property </param>
        /// <returns>this instance</returns>
        public ChapInfo WithSecretToAuthenticateTarget(string secretToAuthenticateTarget)
        {
            this.secretToAuthenticateTarget = secretToAuthenticateTarget;
            return this;
        }
            

        // Check to see if SecretToAuthenticateTarget property is set
        internal bool IsSetSecretToAuthenticateTarget()
        {
            return this.secretToAuthenticateTarget != null;       
        }
    }
}
