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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about your account's suppression preferences.
    /// </summary>
    public partial class SuppressionOptions
    {
        private List<string> _suppressedReasons = new List<string>();

        /// <summary>
        /// Gets and sets the property SuppressedReasons. 
        /// <para>
        /// A list of reasons to suppress email addresses. The only valid reasons are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COMPLAINT</code> – Amazon SES will suppress an email address that receives
        /// a complaint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BOUNCE</code> – Amazon SES will suppress an email address that hard bounces.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> SuppressedReasons
        {
            get { return this._suppressedReasons; }
            set { this._suppressedReasons = value; }
        }

        // Check to see if SuppressedReasons property is set
        internal bool IsSetSuppressedReasons()
        {
            return this._suppressedReasons != null && this._suppressedReasons.Count > 0; 
        }

    }
}