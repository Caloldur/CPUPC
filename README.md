# How to use
Download from releases.

Run the file as administrator.

Select the process that contains the executable in question.

Select priority.

Click Set.

Relaunch application in question to see the new cpu priority.

# How it works

It adds a registry key for the selected executable and a sub key for PerfOptions, and another value for CpuPriorityClass
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\<Process>\PerfOptions
CpuPriorityClass

# Warnings
Junk code, not really a developer.

# Thanks 

Thanks go out to mirko8054 on reddit for their instructions on doing this for a video game.
https://www.reddit.com/r/starcitizen/comments/qw6ff7/set_cpu_priority_after_easy_anti_cheat_release/
