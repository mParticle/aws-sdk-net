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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListCommandInvocationsResponse : AmazonWebServiceResponse
    {
        private List<CommandInvocation> _commandInvocations = new List<CommandInvocation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CommandInvocations. (Optional) A list of all invocations.
        /// </summary>
        public List<CommandInvocation> CommandInvocations
        {
            get { return this._commandInvocations; }
            set { this._commandInvocations = value; }
        }

        // Check to see if CommandInvocations property is set
        internal bool IsSetCommandInvocations()
        {
            return this._commandInvocations != null && this._commandInvocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. (Optional) The token for the next set of items
        /// to return. (You received this token from a previous call.)
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}